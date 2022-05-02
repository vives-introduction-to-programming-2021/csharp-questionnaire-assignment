using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionnaireLibrary
{
    public class MultipleChoiceOption
    {
        // Constructor
        public MultipleChoiceOption()
        {
        }

        // 2nd constructor (constructor overloading)
        public MultipleChoiceOption(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

        public override string ToString()
        {
            return Text;
        }

        // prop
        public bool IsCorrect { get; set; }

        // propfull
        public string Text
        {
            get { return text; }
            set
            {
                if (value == null)
                {
                    value = "";
                }
                text = value;
            }
        }

        // Attributes
        private string text = "";
    }
}
