using BusinnessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_proje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        
        //controllere yaklaştığımız gibi yaklaşıyoruz
        //view ekleyemiyoruz View içindeki Shared Klasörüne Components ekliyoruz. ardından bu klasörün içine FeatureList klasörü ekliyoruz. ***Klasör ismi ile class ismi aynı olmalı.
        //Klasör içine ismi Default olan bir partial view ekliyoruz. 
        //componentleri kullanmanın sebebi direkt erişimi engellemek
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
            return View(values);
        }
        
    }
}
