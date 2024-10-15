using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MVCUnitInformationConverter.Pages
{
    public class IndexModel : PageModel
    {
        // исходное количество информации
        public double InitialInf { get; set; }
        // исходная единица измерения
        public string InitialVal { get; set; } = string.Empty;
        // ед. измерения, в которую нужно конвертировать
        public string ConvertedVal { get; set; } = string.Empty;
        // конечное количество информации
        public double ConvertedInf { get; set; }
        public void OnGet(string initialVal, string convertedVal, double initialInf)
        {
            InitialVal = initialVal;
            ConvertedVal = convertedVal;

            double convertedInf = 0;
            if (initialVal == "bit")
            {
                if (convertedVal == "bytes")
                {
                    convertedInf = initialInf / 8;
                }
                if (convertedVal == "kilobytes")
                {
                    convertedInf = initialInf / 8000;
                }
                if (convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 8_000_000;
                }
                if (convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 8_000_000_000;
                }
                if (convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 8_000_000_000_000;
                }
            }
            if (initialVal == "bytes")
            {
                if (convertedVal == "bit")
                {
                    convertedInf = initialInf * 8;
                }
                if (convertedVal == "kilobytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
                if (convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1_000_000_000;
                }
                if (convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000_000_000;
                }
            }
            if (initialVal == "kilobytes")
            {
                if (convertedVal == "bit")
                {
                    convertedInf = initialInf * 8000;
                }
                if (convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "megabytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
                if (convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000_000;
                }
            }
            if (initialVal == "megabytes")
            {
                if (convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000;
                }
                if (convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "gigabytes")
                {
                    convertedInf = initialInf / 1000;
                }
                if (convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1_000_000;
                }
            }
            if (initialVal == "gigabytes")
            {
                if (convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000_000;
                }
                if (convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000_000;
                }
                if (convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "megabytes")
                {
                    convertedInf = initialInf * 1000;
                }
                if (convertedVal == "tarabytes")
                {
                    convertedInf = initialInf / 1000;
                }
            }
            if (initialVal == "tarabytes")
            {
                if (convertedVal == "bit")
                {
                    convertedInf = initialInf * 8_000_000_000_000;
                }
                if (convertedVal == "bytes")
                {
                    convertedInf = initialInf * 1_000_000_000_000;
                }
                if (convertedVal == "kilobytes")
                {
                    convertedInf = initialInf * 1_000_000_0000;
                }
                if (convertedVal == "megabytes")
                {
                    convertedInf = initialInf * 1_000_000;
                }
                if (convertedVal == "gigabytes")
                {
                    convertedInf = initialInf * 1000;
                }
            }

            InitialInf = initialInf;            
            ConvertedInf = convertedInf;            
        }
    }
}
