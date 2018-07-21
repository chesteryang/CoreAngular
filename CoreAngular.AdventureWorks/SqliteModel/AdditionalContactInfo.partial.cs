using System.IO;
using System.Xml.Serialization;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class AdditionalContactInfo
    {
        public static AdditionalContactInfo Deserialize(string info)
        {
            using (var reader = new StringReader(info))
            {
                return new XmlSerializer(typeof(AdditionalContactInfo)).Deserialize(reader) as AdditionalContactInfo;
            }
        }
    }
}
