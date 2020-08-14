using ObjCRuntime;

namespace PCPersonalCloud
{
	[Native]
	public enum SPAlertHaptic : long
	{
		Success = 0,
		Warning = 1,
		Error = 2,
		None = 3
	}

	[Native]
	public enum SPAlertPreset : long
	{
		Done = 0,
		Heart = 1,
		Document = 2,
		Bookmark = 3,
		Moon = 4,
		Star = 5,
		Warning = 6,
		Flag = 7,
		Message = 8,
		Question = 9,
		Bolt = 10,
		Add = 11,
		Error = 12,
		Shuffle = 13,
		Repeat = 14,
		Eject = 15,
		Card = 16,
		Rotate = 17,
		Like = 18,
		Dislike = 19,
		Privacy = 20,
		Cart = 21,
		Search = 22
	}
}
