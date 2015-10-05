using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Phoneword
{
	public class ProductModel1 
    {
		static ProductModel1()
        {
            //All = new ObservableCollection<ProductModel1>
            {
				new ProductModel1 {
					Name = "Cup soup",
					Image = "Product1.png",
    
				};
				new ProductModel1 {
					Name = "Nutella",
					Image = "Product2.png",
           
				};
				new ProductModel1 {

                   
				};
            };
        }

        public string Name { set; get; }

        public string Image { set; get; }



		//public static IList<ProductModel> All { set; get; }
    }
}
