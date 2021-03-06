﻿using System.Diagnostics.CodeAnalysis;

namespace Rainbow.Storage
{
	[ExcludeFromCodeCoverage]
	public class TreeRoot
	{
		public TreeRoot(string name, string path, string databaseName)
		{
			Name = name;
			Path = path;
			DatabaseName = databaseName;
		}

		public string Name { get; protected set; }
		public string Path { get; protected set; }
		public string DatabaseName { get; protected set; }
	}
}
