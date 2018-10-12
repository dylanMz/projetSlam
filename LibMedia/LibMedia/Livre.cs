using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{
    namespace LaibrairieClasses
    {
        public class Livre
        {
            #region Propriete
            /* propriete*/
            private int bd_code;
            private String bd_titre;
            private int bd_num_tome;
            private int bd_annee_parution;
            private String bd_image;
            private String bd_serie;
            private String edi_code;

                #endregion


            #region Constructeur
         public Livre(int wbd_code, String wbd_titre, int wbd_num_tome, int wbd_annee_parution, String wbd_image, String wbd_serie, String wedi_code)
            {
                bd_code = wbd_code;
                bd_titre = wbd_titre;
                bd_num_tome = wbd_num_tome;
                bd_annee_parution = wbd_annee_parution;
                bd_image = wbd_image;
                bd_serie = wbd_serie;
                edi_code = wedi_code;

            }
            #endregion


            #region accesseur

 

            public int Wbd_code
            {
                get { return bd_code; }
                set { bd_code = value; }
            }

           

            public int Wbd_num_tome
            {
                get { return bd_num_tome; }
                set { bd_num_tome = value; }
            }
         

            public String wbd_titre
            {
                get { return bd_titre; }
                set { bd_titre = value; }
            }
           


            public int wbd_annee_parution
            {
                get { return bd_annee_parution; }
                set { bd_annee_parution = value; }
            }


            public String  wbd_image
            {
                get { return bd_image; }
                set { bd_image = value; }
            }

         

            public String wbd_serie
            {
                get { return bd_serie; }
                set { bd_serie = value; }
            }
            

            public String wedi_code
            {
                get { return edi_code; }
                set { edi_code = value; }
            }





            #endregion

        }
    }
}
