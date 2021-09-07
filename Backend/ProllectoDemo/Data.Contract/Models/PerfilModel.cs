using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Data.Contract.Models
{
    public class PerfilModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public List<string> Notas { get; set; }
        public List<string> Imagenes { get; set; }
        
    }
}
