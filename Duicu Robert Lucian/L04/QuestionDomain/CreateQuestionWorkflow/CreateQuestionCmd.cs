using System;

namespace QuestionDomain.CreateQuestionWorkflow
{
    public struct CreateQuestionCmd
    {
        [Required]
        public string Title { get; private set; }
        [Required]
        public string Content { get; private set; }

        public CreateQuestionCmd(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }
}