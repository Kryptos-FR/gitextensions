namespace GitCommands.Git.Tag
{
    public class GitCreateTagArgs
    {
        /// <summary>
        /// Creates arguments for creation of a tag.
        /// </summary>
        /// <param name="tagName">Name of tag</param>
        /// <param name="revision">Commit revision to be tagged</param>
        /// <param name="operation">The operation to perform on the tag</param>
        /// <param name="tagMessage">Tag Message</param>
        /// <param name="signKeyId">Specific Key ID to be used instead of default one</param>
        /// <param name="force">Force parameter</param>
        public GitCreateTagArgs(string tagName, string revision, TagOperation operation = TagOperation.Lightweight, string tagMessage = "", string signKeyId = "", bool force = false)
        {
            TagName = tagName;
            Revision = revision;
            Operation = operation;
            TagMessage = tagMessage;
            SignKeyId = signKeyId;
            Force = force;
        }

        public bool Force { get; }
        public TagOperation Operation { get; }
        public string Revision { get; }
        public string TagMessage { get; }
        public string TagName { get; }
        public string SignKeyId { get; }
    }
}