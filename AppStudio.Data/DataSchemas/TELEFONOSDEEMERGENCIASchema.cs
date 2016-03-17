using System;
using System.Collections;
using Newtonsoft.Json;

namespace AppStudio.Data
{
    /// <summary>
    /// Implementation of the TELEFONOSDEEMERGENCIASchema class.
    /// </summary>
    public class TELEFONOSDEEMERGENCIASchema : BindableSchemaBase, IEquatable<TELEFONOSDEEMERGENCIASchema>, ISyncItem<TELEFONOSDEEMERGENCIASchema>
    {
        private string _nombre;
        private string _subtitle;
        private string _imagen;
        [JsonProperty("_id")]
        public string Id { get; set; }

 
        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }
 
        public string Subtitle
        {
            get { return _subtitle; }
            set { SetProperty(ref _subtitle, value); }
        }
 
        public string imagen
        {
            get { return _imagen; }
            set { SetProperty(ref _imagen, value); }
        }

        public override string DefaultTitle
        {
            get { return Nombre; }
        }

        public override string DefaultSummary
        {
            get { return null; }
        }

        public override string DefaultImageUrl
        {
            get { return imagen; }
        }

        public override string DefaultContent
        {
            get { return null; }
        }

        override public string GetValue(string fieldName)
        {
            if (!String.IsNullOrEmpty(fieldName))
            {
                switch (fieldName.ToLowerInvariant())
                {
                    case "nombre":
                        return String.Format("{0}", Nombre); 
                    case "subtitle":
                        return String.Format("{0}", Subtitle); 
                    case "imagen":
                        return String.Format("{0}", imagen); 
                    case "defaulttitle":
                        return DefaultTitle;
                    case "defaultsummary":
                        return DefaultSummary;
                    case "defaultimageurl":
                        return DefaultImageUrl;
                    default:
                        break;
                }
            }
            return String.Empty;
        }

        public bool Equals(TELEFONOSDEEMERGENCIASchema other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (ReferenceEquals(null, other)) return false;
            return this.Id == other.Id;
        }

        public bool NeedSync(TELEFONOSDEEMERGENCIASchema other)
        {

            return this.Id == other.Id && (this.Nombre != other.Nombre || this.Subtitle != other.Subtitle || this.imagen != other.imagen);
        }

        public void Sync(TELEFONOSDEEMERGENCIASchema other)
        {
            this.Nombre = other.Nombre;
            this.Subtitle = other.Subtitle;
            this.imagen = other.imagen;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TELEFONOSDEEMERGENCIASchema);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
