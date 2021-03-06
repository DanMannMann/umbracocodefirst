using System;
using System.Linq;
using System.Collections.Generic;
using Marsman.UmbracoCodeFirst.Attributes;
using Marsman.UmbracoCodeFirst.DataTypes;
using Marsman.UmbracoCodeFirst.Dictionaries;

namespace Marsman.UmbracoCodeFirst.QuizDemo.DocTypes
{
	[Dictionary]
	public class QuizmasterDictionary : DictionaryBase
	{
		[Item(defaultValue: "Yey! Your answer is correct!")]
		public string CorrectAnswer { get; set; }

		[Item(defaultValue: "Oh noes! Your answer was total nonsense!")]
		public string IncorrectAnswer { get; set; }

		[Item(defaultValue: "That's the end of the quiz! Click to re-play.")]
		public string NoMoreQuestions { get; set; }

		[Item(defaultValue: "Copyright � 2015 Marsman Ltd")]
		public string CopyrightMessage { get; set; }

		[Item(defaultValue: "Please choose the question set you would like to complete:")]
		public string ChooseQuestionSet { get; set; }

		[Item(defaultValue: "Fun Factoid")]
		public string FactoidTitle { get; set; }
	}
}