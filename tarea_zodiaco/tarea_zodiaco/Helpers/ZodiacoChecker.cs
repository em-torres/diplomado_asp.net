using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tarea_zodiaco.Helpers
{
    public class ZodiacoChecker
    {
        public string imagen_signo(DateTime? fecha)
        {
            string ruta_imagen = fecha.Value.ToString();

            int day = fecha.Value.Day;
            int month = fecha.Value.Month;

            switch (month)
            {
                case 1:
                    if (day < 21)
                        ruta_imagen = "capri.jpg";
                    else
                        ruta_imagen = "acuar.jpg";
                    break;
                case 2:
                    if (day < 20)
                        ruta_imagen = "acuar.jpg";
                    else
                        ruta_imagen = "pisci.jpg";
                    break;
                case 3:
                    if (day < 22)
                        ruta_imagen = "pisci.jpg";
                    else
                        ruta_imagen = "aries.jpg";
                    break;
                case 4:
                    if (day < 19)
                        ruta_imagen = "aries.jpg";
                    else
                        ruta_imagen = "tauro.jpg";
                    break;
                case 5:
                    if (day < 20)
                        ruta_imagen = "tauro.jpg";
                    else
                        ruta_imagen = "gemin.jpg";
                    break;
                case 6:
                    if (day < 20)
                        ruta_imagen = "gemin.jpg";
                    else
                        ruta_imagen = "cancer.jpg";
                    break;
                case 7:
                    if (day < 23)
                        ruta_imagen = "cancer.jpg";
                    else
                        ruta_imagen = "leo.jpg";
                    break;
                case 8:
                    if (day < 24)
                        ruta_imagen = "leo.jpg";
                    else
                        ruta_imagen = "virgo.jpg";
                    break;
                case 9:
                    if (day < 23)
                        ruta_imagen = "virgo.jpg";
                    else
                        ruta_imagen = "libra.jpg";
                    break;
                case 10:
                    if (day < 23)
                        ruta_imagen = "libra.jpg";
                    else
                        ruta_imagen = "escor.jpg";
                    break;
                case 11:
                    if (day < 22)
                        ruta_imagen = "escor.jpg";
                    else
                        ruta_imagen = "sagit.jpg";
                    break;
                case 12:
                    if (day < 22)
                        ruta_imagen = "sagit.jpg";
                    else
                        ruta_imagen = "capri.jpg";
                    break;
            }

            return ruta_imagen;
        }
    }
}