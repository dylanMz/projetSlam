
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMedia
{

        public class Livre
        {
            #region Propriete
            /* propriete*/
            private int bdCode;
            private String bdTitre;
            private int bdNumTome;
            private String bdAnneeParution;
            private String bdImage;
            private int numSerie;
         
            private String bdIsbn;
            private int bdPages;
            private String bdCouleur;
            private String bdCommentaires;
            private String bdFormat;
            private int numEditeur;
                #endregion

             
            #region Constructeur
            public Livre(int wbdcode, String wbdtitre,String wbdisbn, int wbdnumtome ,String wbdanneeparution,int wbdpages, String wbdimage,String wbdcouleur,String wbdcommentaires,String wbdformat ,int wseriecode, int wedicode)
            {
                bdCode = wbdcode;
                bdTitre = wbdtitre;
                bdNumTome = wbdnumtome;
                bdAnneeParution = wbdanneeparution;
                bdImage = wbdimage;
                numSerie = wseriecode;
                numEditeur = wedicode;

                bdIsbn = wbdisbn;
                bdPages = wpages;
                bdCouleur = wcouleur;
                bdCommentaires = wbdcommentaires;
                bdFormat = wbdformat;





            }
            #endregion


            #region accesseur

 

            public int Wbd_code
            {
                get { return bdCode; }
                set { bdCode = value; }
            }

           

            public int Wbd_num_tome
            {
                get { return bdNumTome; }
                set { bdNumTome = value; }
            }
         

            public String wbd_titre
            {
                get { return bdTitre; }
                set { bdTitre = value; }
            }
           


            public String wbd_annee_parution
            {
                get { return bdAnneeParution; }
                set { bdAnneeParution = value; }
            }
        

            public String  wbd_image
            {
                get { return bdImage; }
                set { bdImage = value; }
            }

         

            public int wbd_serie
            {
                get { return numSerie; }
                set { numSerie = value; }
            }
            

            public int wedi_code
            {
                get { return numEditeur; }
                set { numEditeur = value; }
            }

            

            public int wpages
            {
                get { return bdPages; }
                set { bdPages = value; }
            }

            

            public String wisbn
            {
                get { return bdIsbn; }
                set { bdIsbn = value; }
            }

      

            public String wcouleur
            {
                get { return bdCouleur; }
                set { bdCouleur = value; }
            }
           

            public String wcommentaires
            {
                get { return bdCommentaires; }
                set { bdCommentaires = value; }
            }

            

            public String wFormat
            {
                get { return bdFormat;  }
                set { bdFormat =  value; }
            }


            #endregion

        }
    }

