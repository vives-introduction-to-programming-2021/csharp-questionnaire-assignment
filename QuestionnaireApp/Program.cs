using System;
using QuestionnaireLibrary;

namespace QuestionnaireApp
{
  class Program
  {
    static void Main(string[] args)
    {
    //   // New instance of class
    //   MultipleChoiceQuestion question = new MultipleChoiceQuestion();

    //   // Make sure this does not crash the app
    //   //question.SetText(null);
    //   //question.GetText().ToLower();

    //   //Console.WriteLine("The question: " + question.GetText());

    //   question.Text = "Is C# cool to learn?";
    //   Console.WriteLine("Question: " + question.Text);

    //   // Via option 1 (preferred)
    //   question.AddOption("Yes, C# is cool!", true);

    //   // Via option 2
    //   MultipleChoiceOption thirdOption = new MultipleChoiceOption();
    //   thirdOption.Text = "Don't know ...";
    //   thirdOption.IsCorrect = false;
    //   question.AddOption(thirdOption);

    //   MultipleChoiceOption option = new MultipleChoiceOption();
    //   option.Text = "No, C# is boring.";
    //   option.IsCorrect = false;
    //   question.AddOption(option);
    //   Console.WriteLine(option);

    //   Console.WriteLine("\n\n");
    //   Console.WriteLine(question);

        // MultipleChoiceQuestion question = new MultipleChoiceQuestion();
        // question.Text = "Can Chuck Norris defeat Putin?";

        // MultipleChoiceQuestion question = new MultipleChoiceQuestion(
        //     "Can Chuck Norris defeat Putin?"
        // );

        // // First option to add option
        // MultipleChoiceOption option1 = new MultipleChoiceOption();
        // option1.Text = "Putin does not stand a chance!";
        // option1.IsCorrect = true;
        // question.AddOption(option1);

        // // Second option to add option
        // question.AddOption("Chuck will probably die", false);
        // question.AddOption("Putin who ?", false);

        // // Third option (via constructor) to add option
        // MultipleChoiceOption option4 = new MultipleChoiceOption(
        //     "Putin already died yesterday ...", false
        // );
        // question.AddOption(option4);

        // // Fourth option (via constructor) to add option
        // question.AddOption(new MultipleChoiceOption(
        //     "Sorry, Chuck is no more :(.", false
        // ));


        // Console.WriteLine(question);
        // Console.Write("Please pick your option: ");
        // int userAnswer = Convert.ToInt32(Console.ReadLine()) - 1;

        // if (question.IsOptionCorrect(userAnswer))
        // {
        //     Console.WriteLine("Congratz. You are a hero!");
        // }
        // else
        // {
        //     Console.WriteLine("Ooooof size = large. Better luck next time.");
        // }

        // Read each line of the file into a string array. Each element
        // of the array is one line of the file.
        string[] lines = System.IO.File.ReadAllLines("./questions.txt");

        MultipleChoiceQuestion question = null;
        foreach (string line in lines)
        {
            if (line[0] == '#')
            {
                question = new MultipleChoiceQuestion(
                    line.Substring(1)
                );
            }
            else if (line[0] == '+')
            {
                question.AddOption(new MultipleChoiceOption(
                    line.Substring(1), true
                ));
            }
            else if (line[0] == '-')
            {
                question.AddOption(new MultipleChoiceOption(
                    line.Substring(1), false
                ));
            }
            else
            {
                Console.WriteLine(question);
            }

        }

    }
  }
}
