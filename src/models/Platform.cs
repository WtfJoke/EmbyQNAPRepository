using System.Xml.Serialization;

public class Platform
{
    [XmlElement("platformID")]
    public string? PlatformID { get; set; }

    [XmlElement("location")]
    public string? Location { get; set; }
}