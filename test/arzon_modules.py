import requests
import json
import os
from lxml import html
import re

class ArzonScrapy:
    def __init__(self):
        self.headers = {
            'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36',
            'Cookie': "PHPSESSID=8ggl83j6djdvupe4p7srgtdfi4"
        }
        self.auth_url = "https://www.arzon.jp/index.php?action=adult_customer_agecheck&agecheck=1"
        self.base_url = "https://www.arzon.jp"
        self.session = requests.Session()
        self.session.headers.update(self.headers)
        self.authorize()

    # 获取通过年龄认证的session
    def authorize(self) -> None:
        # 进行认证
        response = self.session.get(self.auth_url)
        response.encoding = 'utf-8'
        # print(response.text)
        print(self.session.cookies.get_dict())

    def get_html_tree(self, url: str) -> html.HtmlElement:
        response = self.session.get(url)
        tree = html.fromstring(response.content)
        # response.encoding = 'utf-8'
        # print(response.text)
        return tree

    def search_by_av(self, av_id: str) -> list[dict[str, str]]:
        url = f"https://www.arzon.jp/itemlist.html?t=&m=all&s=&q={av_id}"
        tree = self.get_html_tree(url)
        # 提取搜索结果的链接
        hrefs = tree.xpath('//*[@id="item"]/div/dl/dd/h2/a/@href')
        result_urls = [self.base_url + href for href in hrefs]
        # 获取所有搜索结果的信息
        all_results_info = self.get_all_results_info(result_urls)
        return all_results_info
    
    def get_all_results_info(self, result_urls: str) -> list[dict[str, str]]:
        all_results_info = []
        for url in result_urls:
            all_results_info.append(self.get_av_info(url))
        return all_results_info
    
    def get_av_info(self, url: str) -> dict[str, str]:
        tree = self.get_html_tree(url)
        # 封面
        cover_url = "https:" + tree.xpath("//a[@data-lightbox='jacket1']/@href")[0]
        print(f"封面: {cover_url}")
        cover_path = self.get_image_path(cover_url)
        # 标题
        title = tree.xpath("//h1/text()")[0]
        print(f"标题: {title}")
        # 演员
        actors = tree.xpath("//table[@class='item']/tr[1]/td[2]/a/text()")
        print(f"演员: {actors}")
        # 导演
        director_element = tree.xpath("//table[@class='item']/tr[5]/td[2]")[0]
        if director_element.xpath("a"):
            director = director_element.xpath("a/text()")[0]
        else:
            director = ""
        print(f"导演: {director}")
        # 公司
        maker = tree.xpath("//table[@class='item']/tr[2]/td[2]/a/text()")[0]
        print(f"公司: {maker}")
        # 发行日期
        release_date_raw = tree.xpath("//table[@class='item']/tr[6]/td[2]/text()")[0].strip()
        release_date = re.search(r"\d{4}/\d{2}/\d{2}", release_date_raw).group()
        print(f"发行日期: {release_date}")
        # 片长
        runtime = tree.xpath("//table[@class='item']/tr[7]/td[2]/text()")[0].strip()
        print(f"片长: {runtime}")
        # 番号
        num_raw = tree.xpath("//table[@class='item']/tr[8]/td[2]/text()")[0]
        num = re.search(r"\S+\d+", num_raw).group()
        print(f"番号: {num}")
        # 标签
        tag_element = tree.xpath("//table[@class='item']/tr[9]/td[2]")[0]
        if tag_element.xpath("a"):
            tag = tag_element.xpath("a/text()")
        else:
            tag = ""
        print(f"标签: {tag}")
        # 简介
        introduction_raw = tree.xpath("//div[@class='item_text']")
        if introduction_raw:
            introduction_raw = introduction_raw[0].text_content().strip()
            introduction = re.search(r"作品紹介\s*(\S+)", introduction_raw).group(1)
        else:
            introduction = ""
        print(f"简介: {introduction}")
        return {
            "cover_url": cover_url,
            "cover_path": cover_path,
            "title": title,
            "actors": actors,
            "director": director,
            "maker": maker,
            "release_date": release_date,
            "runtime": runtime,
            "num": num,
            "tag": tag,
            "introduction": introduction
        }
    
    def get_image_path(self, url: str) -> str:
        image_path = f"test/img/{url.split('/')[-1]}"
        if os.path.exists(image_path):
            return image_path
        # 需增加Referer头，否则无法获取图片
        self.session.headers.update({
            'Referer': "https://www.arzon.jp/"
        })
        response = self.session.get(url)
        image_content = response.content
        with open(image_path, "wb") as f:
            f.write(image_content)
        return image_path


if __name__ == '__main__':
    az = ArzonScrapy()
    print(az.search_by_av("SSIS-617"))