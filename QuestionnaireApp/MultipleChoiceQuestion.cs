using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireApp
{
    class MultipleChoiceQuestion
    {
        // Setter for Text
        //public void SetText(string text)
        //{
        //    // Safe-guard
        //    if (text == null)
        //    {
        //        text = "";
        //    }

        //    this.text = text;           // this.text => attribute
        //}

        // Getter for Text
        //public string GetText()
        //{
        //    return text;
        //}

        public MultipleChoiceQuestion(string text)
        {
            Text = text;
        }

        // Generated using 'propfull'
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (value == null)
                {
                    value = "";
                }

                text = value;
            }
        }

        // Option 1 - take in string and bool
        public void AddOption(string text, bool isCorrect)
        {
            MultipleChoiceOption option = new MultipleChoiceOption();
            option.Text = text;
            option.IsCorrect = isCorrect;

            // Add to the options list
            options.Add(option);
        }

        // Option 2 - take in object
        public void AddOption(MultipleChoiceOption option)
        {
            options.Add(option);
        }

        // Method overloading = multiple methods with same name

        public override string ToString()
        {
            // xxxxxxxxxxxx ?
            // (1) ...
            // (2) ....

            string output = Text;
            for (int i = 0; i < options.Count; i++)
            {
                output += $"\n\t{(i + 1)}. {options[i]}";
                // output += "\n\t" + (i+1) + ". " + options[i];
            }

            return output;
        }

        public bool IsOptionCorrect(int index)
        {
            if (index < 0 || index >= options.Count)
            {
                return false;
            }

            return options[index].IsCorrect;
        }

        // Attributes
        private string text = "There should be a question here ...";

        // List of multiple choice options
        private List<MultipleChoiceOption> options = new List<MultipleChoiceOption>();
        // private Random generator = new Random();
    }
}
