using System;
using System.Collections.Generic;

namespace QuestionDomain.CreateQuestionWorkflow
{
    [Serializable]
    public class InvalidQuestionDataException : Exception
    {
        public InvalidQuestionDataException(string title, string Content, List<string> tag) : base(title.Length + "\n" + Content.Length + "\n" + tag.Count)
        {

        }


    }
}