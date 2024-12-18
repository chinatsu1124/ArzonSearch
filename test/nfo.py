import xml.etree.ElementTree as ET

def create_nfo(av_info: dict, nfo_path: str) -> ET.ElementTree:
    root = ET.Element("movie")
    ET.SubElement(root, "plot").text = av_info["introduction"]
    ET.SubElement(root, "title").text = av_info["title"]
    ET.SubElement(root, "director").text = av_info["directors"]
    ET.SubElement(root, "premiered").text = av_info["release_date"].replace("/", "-")
    ET.SubElement(root, "studio").text = av_info["maker"]
    actor = ET.SubElement(root, "actor")
    for actor_str in av_info["actors"]:
        ET.SubElement(actor, "name").text = actor_str
    tree = ET.ElementTree(root)
    tree.write(nfo_path, encoding="utf-8", xml_declaration=True)