using System;
using System.Collections.Generic;

namespace QuestionnaireApp
{
  class QuestionDatabase
  {
    public void AddQuestion(MultipleChoiceQuestion question)
    {
      questions.Add(question);
    }

    public MultipleChoiceQuestion GetRandomQuestion()
    {
      return questions[generator.Next(questions.Count)];
    }

    private List<MultipleChoiceQuestion> questions
            = new List<MultipleChoiceQuestion>();

    private Random generator = new Random();
  }
}