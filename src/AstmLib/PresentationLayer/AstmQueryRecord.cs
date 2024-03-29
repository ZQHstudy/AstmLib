using AstmLib.Configuration;

namespace AstmLib.PresentationLayer
{
    public class AstmQueryRecord : AstmRecord
    {
        #region Constructors

        public AstmQueryRecord(AstmHighLevelSettings highLevelSettings) : base(highLevelSettings)
        {
            Fields = new string[13];
            RecordTypeId = AstmRecordTypeIds.Query;
        }

        #endregion

        #region Fields Definition

        public string SequenceNumber
        {
            get => Fields[1];
            set => Fields[1] = value;
        }

        public string StartingRangeId
        {
            get => Fields[2];
            set => Fields[2] = value;
        }

        public string StatusCode
        {
            get => Fields[12];
            set => Fields[12] = value;
        }

        #endregion
    }
}