﻿namespace EventStore.Persistence.MongoDBPersistence
{
	using System;

	public class MongoDBCommitId
	{
		public Guid StreamId { get; private set; }
		public int CommitSequence { get; private set; }

		public MongoDBCommitId(Guid streamId, int commitSequence)
		{
			StreamId = streamId;
			CommitSequence = commitSequence;
		}
	}
}