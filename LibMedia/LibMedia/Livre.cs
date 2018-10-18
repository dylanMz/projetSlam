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
            private int num_serie;
         
            private String bd_isbn;
            private int bd_pages;
            private String bd_couleur;
            private String bd_commentaires;
            private String bd_format;
            private int num_editeur;
                #endregion


            #region Constructeur
         public Livre(int wbd_code, String wbd_titre,String wBdisbn, int wbd_num_tome ,int wbd_annee_parution,int wpages, String wbd_image,String wcouleur,String wCommentaires,String wFormat ,int wbd_serie, int wedi_code)
            {
                bd_code = wbd_code;
                bd_titre = wbd_titre;
                bd_num_tome = wbd_num_tome;
                bd_annee_parution = wbd_annee_parution;
                bd_image = wbd_image;
                num_serie = wbd_serie;
                num_editeur = wedi_code;

                bd_isbn = wBdisbn;
                bd_pages = wpages;
                bd_couleur = wcouleur;
                bd_commentaires = wCommentaires;
                bd_format = wFormat;





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

         

            public int wbd_serie
            {
                get { return num_serie; }
                set { num_serie = value; }
            }
            

            public int wedi_code
            {
                get { return num_editeur; }
                set { num_editeur = value; }
            }

            

            public int wpages
            {
                get { return bd_pages; }
                set { bd_pages = value; }
            }

            

            public String wisbn
            {
                get { return bd_isbn; }
                set { bd_isbn = value; }
            }

      

            public String wcouleur
            {
                get { return bd_couleur; }
                set { bd_couleur = value; }
            }
           

            public String wcommentaires
            {
                get { return bd_commentaires; }
                set { bd_commentaires = value; }
            }

            

            public String wFormat
            {
                get { return bd_format;  }
                set { bd_format =  value; }
            }


            #endregion

        }
    }
}
