import shutil
import os
import nfo
from PIL import Image

def resize_and_crop_image(image_path: str, output_path: str, target_height: int, crop_width: int):
    with Image.open(image_path) as img:
        # 等比缩放图片高度到 target_height
        aspect_ratio = img.width / img.height
        new_height = target_height
        new_width = int(aspect_ratio * new_height)
        img = img.resize((new_width, new_height), Image.LANCZOS)
        
        # 从右到左裁剪宽度为 crop_width
        left = new_width - crop_width
        top = 0
        right = new_width
        bottom = new_height
        img = img.crop((left, top, right, bottom))
        
        # 保存处理后的图片
        img.save(output_path)

def rename_av(video_path: str, av_info: dict):
    # 重命名视频文件
    video_name = os.path.basename(video_path)
    video_dir = os.path.dirname(video_path)
    video_ext = os.path.splitext(video_name)[1]
    new_video_name = f"{av_info['num']}{video_ext}"
    new_video_path = os.path.join(video_dir, new_video_name)
    shutil.move(video_path, new_video_path)
    
    # 重命名封面图并修改封面图尺寸和裁剪
    cover_name = os.path.basename(av_info["cover_path"])
    cover_ext = os.path.splitext(cover_name)[1]
    new_cover_name = f"{av_info['num']}{cover_ext}"
    new_cover_path = os.path.join(video_dir, new_cover_name)
    shutil.move(av_info["cover_path"], new_cover_path)
    
    # 调整封面图尺寸和裁剪
    resize_and_crop_image(new_cover_path, new_cover_path, 1076, 756)
    
    # 生成视频nfo文件
    nfo_path = os.path.join(video_dir, f"{av_info['num']}.nfo")
    nfo.create_nfo(av_info, nfo_path)