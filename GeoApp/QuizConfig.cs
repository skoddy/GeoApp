using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoApp
{
    public class QuizConfig
    {
        // Singleton Pattern
        private static QuizConfig _instance;

        public static QuizConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new QuizConfig();
                }
                return _instance;
            }
        }

        public QuestionType Qt { get; set; }
        public AnswerType At { get; set; }
        public string Continent { get; set; }
        public int MaxQuestions { get; set; } = 10;
    }
}
