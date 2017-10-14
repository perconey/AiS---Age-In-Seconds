using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGe_in_seconds
{
    class Resources
    {
        private string _userInput;
        private DateTime _date;
        private long seconds;

        public string UserInput { get => _userInput; set => _userInput = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public long Seconds { get => seconds; set => seconds = value; }

        /// <summary>
        /// Sets Date field to converted string provided in first argument
        /// </summary>
        /// <param name="input"></param>
        public Resources(string input)
        {
            Date = Convert.ToDateTime(input);
            Seconds = 0;
        }
        /// <summary>
        /// Default constructor
        /// No on-create code implemented nibba
        /// </summary>
        public Resources()
        {
            Seconds = 0;
        }

        /// <summary>
        /// Sets UserInput field to string input provided in argument, and converts it for Date field binding
        /// Leap year seconds = 31622400
        /// Regular year seconds = 31556926
        /// </summary>
        /// <param name="inp"></param>
        public void FieldSetConvert(string input)
        {
            int i, yrCounter;
            UserInput = input;
            try
            {
                 Date = Convert.ToDateTime(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for(i = (DateTime.Now.Year - Date.Year); i > 0; i--)
            {
                yrCounter = Date.Year;
                if(DateTime.IsLeapYear(yrCounter))
                {
                    Seconds += 31622400;
                }
                Seconds += 31556926;
            } 
            Seconds += (DateTime.Now.Hour * 60 * 60) + (DateTime.Now.Minute * 60) + DateTime.Now.Second;
        }
    }
}
