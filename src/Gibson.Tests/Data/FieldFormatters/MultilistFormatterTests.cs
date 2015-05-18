﻿using Gibson.Data.FieldFormatters;
using NUnit.Framework;

namespace Gibson.Tests.Data.FieldFormatters
{
	public class MultilistFieldFormatterTests
	{
		private const string SourceValueExpectation = "{39889053-84C2-4D33-BF01-0D51DF5A1E8A}|{7D1E1C69-B085-4DF3-9085-F09498A2A32C}|{2E5892C5-A529-4646-989B-1F15DE10453E}|{8EF706F3-71D1-4EE2-BADF-99018AF186C9}";
		private const string FormattedValueExpectation = "{39889053-84C2-4D33-BF01-0D51DF5A1E8A}\r\n{7D1E1C69-B085-4DF3-9085-F09498A2A32C}\r\n{2E5892C5-A529-4646-989B-1F15DE10453E}\r\n{8EF706F3-71D1-4EE2-BADF-99018AF186C9}";
		
		[Test]
		public void MultilistFormatter_FormatsValues_AsExpected()
		{
			var formatter = new MultilistFormatter();

			var result = formatter.Format(new FakeSerializableFieldValue(SourceValueExpectation));

			Assert.AreEqual(result, FormattedValueExpectation);
		}

		[Test]
		public void MultilistFormatter_ReturnsValues_AsExpected()
		{
			var formatter = new MultilistFormatter();

			var result = formatter.Unformat(FormattedValueExpectation);

			Assert.AreEqual(result, SourceValueExpectation);
		}
	}
}