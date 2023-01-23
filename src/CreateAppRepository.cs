using System.Text.Json;
using System.Xml.Serialization;


class CreateAppRepository
{

    const string QNAP_VERSION = "4.3.4";
    string[] QNAP_PLATFORMS = { "TS-NASX86", "TS-X28A", "TS-X32", "TS-X32U", "TS-XA28A" };


    public List<Person> ReadPersons()
    {
        var json = File.ReadAllText("persons.json");
        var persons = JsonSerializer.Deserialize<List<Person>>(json);
        return persons ?? new List<Person>();
    }

    public void WriteAppRepository(List<Person> persons)
    {
        var serializer = new XmlSerializer(typeof(List<Person>));
        using (var writer = new StreamWriter("persons.xml"))
        {
            serializer.Serialize(writer, persons);
        }
    }

}



