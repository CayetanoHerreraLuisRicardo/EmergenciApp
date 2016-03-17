using System;

using Windows.ApplicationModel;

namespace AppStudio.ViewModels
{
    public class AboutThisAppViewModel
    {
        public string Publisher
        {
            get
            {
                return "RichyCH";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "Esta App basica sirve como ayuda en caso de mergencias, contiene todos los telefo" +
    "nos de emergencia y asistencia que operan dentro de la republica Méxicana. Solo " +
    "es cuestion de elejir la emergencia, click en el numero y listo tu llamada será " +
    "procesada.";
            }
        }
    }
}

