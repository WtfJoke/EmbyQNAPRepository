using System.Xml.Serialization;

[XmlRoot("plugins")]
public class Plugins
{
    [XmlElement("item")]
    public List<Item>? Items { get; set; }
}