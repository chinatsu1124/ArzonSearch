from PySide6.QtWidgets import (
    QApplication, QMainWindow, QWidget, QPushButton, QLineEdit, QListWidget,
    QLabel, QGroupBox, QCheckBox, QProgressBar, QTextEdit, QVBoxLayout,
    QHBoxLayout, QGridLayout, QFormLayout, QTableWidget, QTableWidgetItem,
    QTabWidget, QSplitter, QFrame, QScrollArea, QStackedLayout, QDialog
)
from PySide6.QtGui import QPixmap, QDragEnterEvent, QDropEvent
from PySide6.QtCore import Qt, QUrl
from arzon_modules import ArzonScrapy
import re
import rename_modules as rename

class MainWindow(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("ArzonSearch")
        self.resize(1400, 900)

        # 设置窗口接受拖放操作
        self.setAcceptDrops(True)

        # 创建主部件和布局
        central_widget = QWidget()
        self.setCentralWidget(central_widget)
        main_layout = QVBoxLayout(central_widget)

        # 搜索组
        self.gbx_search = QGroupBox("搜索")
        main_layout.addWidget(self.gbx_search)
        search_layout = QHBoxLayout(self.gbx_search)

        self.cbx_fbi = QCheckBox("FBI WARNING")
        search_layout.addWidget(self.cbx_fbi)

        self.txt_search = QLineEdit()
        search_layout.addWidget(self.txt_search)

        self.btn_av_search = QPushButton("有码搜索")
        search_layout.addWidget(self.btn_av_search)

        self.btn_anime_search = QPushButton("动漫搜索")
        search_layout.addWidget(self.btn_anime_search)

        self.btn_magnet = QPushButton("磁力搜索")
        search_layout.addWidget(self.btn_magnet)

        self.btn_nfo = QPushButton("NFO")
        search_layout.addWidget(self.btn_nfo)

        self.pgb_keyword = QProgressBar()
        search_layout.addWidget(self.pgb_keyword)

        self.lbl_proxy_tip = QLabel("代理提示")
        search_layout.addWidget(self.lbl_proxy_tip)

        # 番号列表，海报，信息在一个水平布局里
        num_post_info_layout = QHBoxLayout()
        main_layout.addLayout(num_post_info_layout)
        
        # 番号列表组
        self.gbx_num = QGroupBox("番号列表")
        num_post_info_layout.addWidget(self.gbx_num)
        num_layout = QVBoxLayout(self.gbx_num)

        self.lbx_num = QListWidget()
        num_layout.addWidget(self.lbx_num)

        # 海报展示组
        self.gbx_poster = QGroupBox("海报")
        num_post_info_layout.addWidget(self.gbx_poster)
        poster_layout = QVBoxLayout(self.gbx_poster)

        self.pbx_post = QLabel()
        poster_layout.addWidget(self.pbx_post)
        self.pbx_post.setAlignment(Qt.AlignCenter)
        self.pbx_post.setPixmap(QPixmap("images/NoImage.jpg"))  # 默认情况下使用Noimage.png
        
        # 信息展示组
        self.gbx_info = QGroupBox("信息")
        num_post_info_layout.addWidget(self.gbx_info)
        info_layout = QGridLayout(self.gbx_info)

        self.lbl_title = QLabel("标题")
        self.tbx_title = QLineEdit()
        info_layout.addWidget(self.lbl_title, 0, 0)
        info_layout.addWidget(self.tbx_title, 0, 1)

        self.lbl_actor = QLabel("演员")
        self.tbx_actor = QLineEdit()
        info_layout.addWidget(self.lbl_actor, 1, 0)
        info_layout.addWidget(self.tbx_actor, 1, 1)

        self.lbl_director = QLabel("导演")
        self.tbx_director = QLineEdit()
        info_layout.addWidget(self.lbl_director, 2, 0)
        info_layout.addWidget(self.tbx_director, 2, 1)

        self.lbl_maker = QLabel("公司")
        self.tbx_maker = QLineEdit()
        info_layout.addWidget(self.lbl_maker, 3, 0)
        info_layout.addWidget(self.tbx_maker, 3, 1)

        self.lbl_release = QLabel("发行日期")
        self.tbx_release = QLineEdit()
        info_layout.addWidget(self.lbl_release, 4, 0)
        info_layout.addWidget(self.tbx_release, 4, 1)

        self.lbl_runtime = QLabel("片长")
        self.tbx_runtime = QLineEdit()
        info_layout.addWidget(self.lbl_runtime, 5, 0)
        info_layout.addWidget(self.tbx_runtime, 5, 1)

        self.lbl_num = QLabel("番号")
        self.tbx_num = QLineEdit()
        info_layout.addWidget(self.lbl_num, 6, 0)
        info_layout.addWidget(self.tbx_num, 6, 1)

        self.lbl_tag = QLabel("标签")
        self.tbx_tag = QLineEdit()
        info_layout.addWidget(self.lbl_tag, 7, 0)
        info_layout.addWidget(self.tbx_tag, 7, 1)

        self.lbl_introduction = QLabel("简介")
        self.tbx_introduction = QTextEdit()
        info_layout.addWidget(self.lbl_introduction, 8, 0)
        info_layout.addWidget(self.tbx_introduction, 8, 1)

        # 磁力链接组
        self.gbx_magnet = QGroupBox("磁力链接")
        # main_layout.addWidget(self.gbx_magnet)
        magnet_layout = QHBoxLayout(self.gbx_magnet)

        self.lbx_magnet = QListWidget()
        magnet_layout.addWidget(self.lbx_magnet)

        magnet_info_widget = QWidget()
        magnet_info_layout = QFormLayout(magnet_info_widget)
        magnet_layout.addWidget(magnet_info_widget)

        self.lbl_magnet_title = QLabel("标题")
        self.tbx_magnet_title = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_title, self.tbx_magnet_title)

        self.lbl_magnet_size = QLabel("大小")
        self.tbx_magnet_size = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_size, self.tbx_magnet_size)

        self.lbl_magnet_seeders = QLabel("做种数")
        self.tbx_magnet_seeders = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_seeders, self.tbx_magnet_seeders)

        self.lbl_magnet_leechers = QLabel("下载数")
        self.tbx_magnet_leechers = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_leechers, self.tbx_magnet_leechers)

        self.lbl_magnet_completes = QLabel("完成数")
        self.tbx_magnet_completes = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_completes, self.tbx_magnet_completes)

        self.lbl_magnet_date = QLabel("日期")
        self.tbx_magnet_date = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_date, self.tbx_magnet_date)

        self.lbl_magnet_download = QLabel("下载链接")
        self.tbx_magnet_download = QLineEdit()
        magnet_info_layout.addRow(self.lbl_magnet_download, self.tbx_magnet_download)
        # 初始化类变量
        self.arzon = ArzonScrapy()
        self.av_infos = []
        self.current_video_path = ""
        # 信号和槽的连接（根据需要添加）
        self.btn_av_search.clicked.connect(self.search_av)
        self.lbx_num.itemClicked.connect(self.show_selected_item_info)
        self.btn_nfo.clicked.connect(self.rename_video)

    # 重写拖放事件处理函数
    def dragEnterEvent(self, event: QDragEnterEvent):
        if event.mimeData().hasUrls():
            event.acceptProposedAction()

    def dropEvent(self, event: QDropEvent):
        urls = event.mimeData().urls()
        if urls:
            file_path = urls[0].toLocalFile()
            file_name = file_path.split("/")[-1].split(".")[0]
            print(file_name)
            num = re.search(r"[A-Za-z]+\-\d+", file_name).group()
            self.txt_search.setText(num)
            self.current_video_path = file_path

    # 搜索函数
    def search_av(self):
        self.av_infos.clear()
        self.lbx_num.clear()
        av_id = self.txt_search.text()
        self.av_infos = self.arzon.search_by_av(av_id)
        for av_info in self.av_infos:
            self.lbx_num.addItem(av_info["num"])

    # 显示选中的番号信息
    def show_selected_item_info(self):
        selected_item = self.lbx_num.currentItem()
        index = self.lbx_num.row(selected_item)
        av_info = self.av_infos[index]
        self.tbx_title.setText(av_info["title"])
        self.tbx_actor.setText(",".join(av_info["actors"]))
        self.tbx_director.setText(av_info["director"])
        self.tbx_maker.setText(av_info["maker"])
        self.tbx_release.setText(av_info["release_date"])
        self.tbx_runtime.setText(av_info["runtime"])
        self.tbx_num.setText(av_info["num"])
        self.tbx_tag.setText(",".join(av_info["tag"]))
        self.tbx_introduction.setText(av_info["introduction"])
        # 显示海报
        pixmap = QPixmap(av_info["cover_path"])
        scaled_pixmap = pixmap.scaled(self.pbx_post.size(), Qt.KeepAspectRatio, Qt.SmoothTransformation)
        self.pbx_post.setPixmap(scaled_pixmap)

    # 视频文件重命名
    def rename_video(self):
        selected_item = self.lbx_num.currentItem()
        index = self.lbx_num.row(selected_item)
        av_info = self.av_infos[index]
        rename.rename_av(self.current_video_path, av_info)


if __name__ == "__main__":
    import sys

    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())