using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class TELEFONOSDEEMERGENCIA1DataSource : DataSourceBase<TELEFONOSDEEMERGENCIASchema>
    {
        private const string _file = "/Assets/Data/TELEFONOSDEEMERGENCIA1DataSource.json";

        protected override string CacheKey
        {
            get { return "TELEFONOSDEEMERGENCIA1DataSource"; }
        }

        public override bool HasStaticData
        {
            get { return false; }
        }

        public async override Task<IEnumerable<TELEFONOSDEEMERGENCIASchema>> LoadDataAsync()
        {
            try
            {
                var serviceDataProvider = new StaticDataProvider(_file);
                return await serviceDataProvider.Load<TELEFONOSDEEMERGENCIASchema>();
            }
            catch (Exception ex)
            {
                AppLogs.WriteError("TELEFONOSDEEMERGENCIA1DataSource.LoadData", ex.ToString());
                return new TELEFONOSDEEMERGENCIASchema[0];
            }
        }
    }
}
