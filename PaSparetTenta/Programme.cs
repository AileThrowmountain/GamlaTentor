using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaSparetTenta
{
    class Programme
    {
        public int Jackpot { get; set; }

        private List<Question> questions { get; set; } = new List<Question>();

        public Programme()
        {
            for (int i = 1; i < 50; i++)
            {
                Question question = new Question(i); //tilldelar varje gång objektet skapar tack vare måsvingar

                questions.Add(question);
            }
        }
        public List<Question> GetUnansweredQuestions()
        {

            List<Question> onlyUnansweredQuestions = new List<Question>(); // Skapa en ny, ren lista som bara innehåller obesvarade frågor

            foreach (Question currentQuestion in questions) // Loopa igenom ALLA frågor
            {
                if (currentQuestion.IsTaken == false) // Om frågan INTE har blivit besvarad, lägg till den i den nya listan som enbart innehåller obesvarade frågor
                {
                    onlyUnansweredQuestions.Add(currentQuestion);
                }
            }

            return onlyUnansweredQuestions; // Returnera din lista som enbart innehåller obesvarade frågor
        }

    }
}
