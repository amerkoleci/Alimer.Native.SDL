// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace SDL3;

public enum SDL_SpinLock : int
{
}

public enum SDL_AudioDeviceID : uint
{
}

[Flags]
public enum SDL_BlendMode : uint
{
	None = SDL3.SDL_BLENDMODE_NONE,
	Blend = SDL3.SDL_BLENDMODE_BLEND,
	BlendPremultiplied = SDL3.SDL_BLENDMODE_BLEND_PREMULTIPLIED,
	Add = SDL3.SDL_BLENDMODE_ADD,
	AddPremultiplied = SDL3.SDL_BLENDMODE_ADD_PREMULTIPLIED,
	Mod = SDL3.SDL_BLENDMODE_MOD,
	Mul = SDL3.SDL_BLENDMODE_MUL,
	Invalid = SDL3.SDL_BLENDMODE_INVALID,
}

public enum SDL_CameraID : uint
{
}

[Flags]
public enum SDL_GlobFlags : uint
{
	CaseInsensitive = SDL3.SDL_GLOB_CASEINSENSITIVE,
}

public enum SDL_HapticID : uint
{
}

[Flags]
public enum SDL_InitFlags : uint
{
	Timer = SDL3.SDL_INIT_TIMER,
	Audio = SDL3.SDL_INIT_AUDIO,
	Video = SDL3.SDL_INIT_VIDEO,
	Joystick = SDL3.SDL_INIT_JOYSTICK,
	Haptic = SDL3.SDL_INIT_HAPTIC,
	Gamepad = SDL3.SDL_INIT_GAMEPAD,
	Events = SDL3.SDL_INIT_EVENTS,
	Sensor = SDL3.SDL_INIT_SENSOR,
	Camera = SDL3.SDL_INIT_CAMERA,
}

public enum SDL_JoystickID : uint
{
}

public enum SDL_KeyboardID : uint
{
}

public enum SDL_Keycode : uint
{
	Unknown = SDL3.SDLK_UNKNOWN,
	Return = SDL3.SDLK_RETURN,
	Escape = SDL3.SDLK_ESCAPE,
	Backspace = SDL3.SDLK_BACKSPACE,
	Tab = SDL3.SDLK_TAB,
	Space = SDL3.SDLK_SPACE,
	Exclaim = SDL3.SDLK_EXCLAIM,
	Dblapostrophe = SDL3.SDLK_DBLAPOSTROPHE,
	Hash = SDL3.SDLK_HASH,
	Dollar = SDL3.SDLK_DOLLAR,
	Percent = SDL3.SDLK_PERCENT,
	Ampersand = SDL3.SDLK_AMPERSAND,
	Apostrophe = SDL3.SDLK_APOSTROPHE,
	LeftParen = SDL3.SDLK_LEFTPAREN,
	RightParen = SDL3.SDLK_RIGHTPAREN,
	Asterisk = SDL3.SDLK_ASTERISK,
	Plus = SDL3.SDLK_PLUS,
	Comma = SDL3.SDLK_COMMA,
	Minus = SDL3.SDLK_MINUS,
	Period = SDL3.SDLK_PERIOD,
	Slash = SDL3.SDLK_SLASH,
	_0 = SDL3.SDLK_0,
	_1 = SDL3.SDLK_1,
	_2 = SDL3.SDLK_2,
	_3 = SDL3.SDLK_3,
	_4 = SDL3.SDLK_4,
	_5 = SDL3.SDLK_5,
	_6 = SDL3.SDLK_6,
	_7 = SDL3.SDLK_7,
	_8 = SDL3.SDLK_8,
	_9 = SDL3.SDLK_9,
	Colon = SDL3.SDLK_COLON,
	Semicolon = SDL3.SDLK_SEMICOLON,
	Less = SDL3.SDLK_LESS,
	Equals = SDL3.SDLK_EQUALS,
	Greater = SDL3.SDLK_GREATER,
	Question = SDL3.SDLK_QUESTION,
	At = SDL3.SDLK_AT,
	LeftBracket = SDL3.SDLK_LEFTBRACKET,
	Backslash = SDL3.SDLK_BACKSLASH,
	RightBracket = SDL3.SDLK_RIGHTBRACKET,
	Caret = SDL3.SDLK_CARET,
	Underscore = SDL3.SDLK_UNDERSCORE,
	Grave = SDL3.SDLK_GRAVE,
	A = SDL3.SDLK_A,
	B = SDL3.SDLK_B,
	C = SDL3.SDLK_C,
	D = SDL3.SDLK_D,
	E = SDL3.SDLK_E,
	F = SDL3.SDLK_F,
	G = SDL3.SDLK_G,
	H = SDL3.SDLK_H,
	I = SDL3.SDLK_I,
	J = SDL3.SDLK_J,
	K = SDL3.SDLK_K,
	L = SDL3.SDLK_L,
	M = SDL3.SDLK_M,
	N = SDL3.SDLK_N,
	O = SDL3.SDLK_O,
	P = SDL3.SDLK_P,
	Q = SDL3.SDLK_Q,
	R = SDL3.SDLK_R,
	S = SDL3.SDLK_S,
	T = SDL3.SDLK_T,
	U = SDL3.SDLK_U,
	V = SDL3.SDLK_V,
	W = SDL3.SDLK_W,
	X = SDL3.SDLK_X,
	Y = SDL3.SDLK_Y,
	Z = SDL3.SDLK_Z,
	Leftbrace = SDL3.SDLK_LEFTBRACE,
	Pipe = SDL3.SDLK_PIPE,
	Rightbrace = SDL3.SDLK_RIGHTBRACE,
	Tilde = SDL3.SDLK_TILDE,
	Delete = SDL3.SDLK_DELETE,
	PlusMinus = SDL3.SDLK_PLUSMINUS,
	Capslock = SDL3.SDLK_CAPSLOCK,
	F1 = SDL3.SDLK_F1,
	F2 = SDL3.SDLK_F2,
	F3 = SDL3.SDLK_F3,
	F4 = SDL3.SDLK_F4,
	F5 = SDL3.SDLK_F5,
	F6 = SDL3.SDLK_F6,
	F7 = SDL3.SDLK_F7,
	F8 = SDL3.SDLK_F8,
	F9 = SDL3.SDLK_F9,
	F10 = SDL3.SDLK_F10,
	F11 = SDL3.SDLK_F11,
	F12 = SDL3.SDLK_F12,
	PrintScreen = SDL3.SDLK_PRINTSCREEN,
	ScrollLock = SDL3.SDLK_SCROLLLOCK,
	Pause = SDL3.SDLK_PAUSE,
	Insert = SDL3.SDLK_INSERT,
	Home = SDL3.SDLK_HOME,
	PageUp = SDL3.SDLK_PAGEUP,
	End = SDL3.SDLK_END,
	PageDown = SDL3.SDLK_PAGEDOWN,
	Right = SDL3.SDLK_RIGHT,
	Left = SDL3.SDLK_LEFT,
	Down = SDL3.SDLK_DOWN,
	Up = SDL3.SDLK_UP,
	NumLockClear = SDL3.SDLK_NUMLOCKCLEAR,
	KpDivide = SDL3.SDLK_KP_DIVIDE,
	KpMultiply = SDL3.SDLK_KP_MULTIPLY,
	KpMinus = SDL3.SDLK_KP_MINUS,
	KpPlus = SDL3.SDLK_KP_PLUS,
	KpEnter = SDL3.SDLK_KP_ENTER,
	Kp1 = SDL3.SDLK_KP_1,
	Kp2 = SDL3.SDLK_KP_2,
	Kp3 = SDL3.SDLK_KP_3,
	Kp4 = SDL3.SDLK_KP_4,
	Kp5 = SDL3.SDLK_KP_5,
	Kp6 = SDL3.SDLK_KP_6,
	Kp7 = SDL3.SDLK_KP_7,
	Kp8 = SDL3.SDLK_KP_8,
	Kp9 = SDL3.SDLK_KP_9,
	Kp0 = SDL3.SDLK_KP_0,
	KpPeriod = SDL3.SDLK_KP_PERIOD,
	Application = SDL3.SDLK_APPLICATION,
	Power = SDL3.SDLK_POWER,
	KpEquals = SDL3.SDLK_KP_EQUALS,
	F13 = SDL3.SDLK_F13,
	F14 = SDL3.SDLK_F14,
	F15 = SDL3.SDLK_F15,
	F16 = SDL3.SDLK_F16,
	F17 = SDL3.SDLK_F17,
	F18 = SDL3.SDLK_F18,
	F19 = SDL3.SDLK_F19,
	F20 = SDL3.SDLK_F20,
	F21 = SDL3.SDLK_F21,
	F22 = SDL3.SDLK_F22,
	F23 = SDL3.SDLK_F23,
	F24 = SDL3.SDLK_F24,
	Execute = SDL3.SDLK_EXECUTE,
	Help = SDL3.SDLK_HELP,
	Menu = SDL3.SDLK_MENU,
	Select = SDL3.SDLK_SELECT,
	Stop = SDL3.SDLK_STOP,
	Again = SDL3.SDLK_AGAIN,
	Undo = SDL3.SDLK_UNDO,
	Cut = SDL3.SDLK_CUT,
	Copy = SDL3.SDLK_COPY,
	Paste = SDL3.SDLK_PASTE,
	Find = SDL3.SDLK_FIND,
	Mute = SDL3.SDLK_MUTE,
	VolumeUp = SDL3.SDLK_VOLUMEUP,
	VolumeDown = SDL3.SDLK_VOLUMEDOWN,
	KpComma = SDL3.SDLK_KP_COMMA,
	KpEqualsas400 = SDL3.SDLK_KP_EQUALSAS400,
	Alterase = SDL3.SDLK_ALTERASE,
	Sysreq = SDL3.SDLK_SYSREQ,
	Cancel = SDL3.SDLK_CANCEL,
	Clear = SDL3.SDLK_CLEAR,
	Prior = SDL3.SDLK_PRIOR,
	Return2 = SDL3.SDLK_RETURN2,
	Separator = SDL3.SDLK_SEPARATOR,
	Out = SDL3.SDLK_OUT,
	Oper = SDL3.SDLK_OPER,
	Clearagain = SDL3.SDLK_CLEARAGAIN,
	Crsel = SDL3.SDLK_CRSEL,
	Exsel = SDL3.SDLK_EXSEL,
	Kp00 = SDL3.SDLK_KP_00,
	Kp000 = SDL3.SDLK_KP_000,
	Thousandsseparator = SDL3.SDLK_THOUSANDSSEPARATOR,
	Decimalseparator = SDL3.SDLK_DECIMALSEPARATOR,
	Currencyunit = SDL3.SDLK_CURRENCYUNIT,
	Currencysubunit = SDL3.SDLK_CURRENCYSUBUNIT,
	KpLeftParen = SDL3.SDLK_KP_LEFTPAREN,
	KpRightParen = SDL3.SDLK_KP_RIGHTPAREN,
	KpLeftbrace = SDL3.SDLK_KP_LEFTBRACE,
	KpRightbrace = SDL3.SDLK_KP_RIGHTBRACE,
	KpTab = SDL3.SDLK_KP_TAB,
	KpBackspace = SDL3.SDLK_KP_BACKSPACE,
	KpA = SDL3.SDLK_KP_A,
	KpB = SDL3.SDLK_KP_B,
	KpC = SDL3.SDLK_KP_C,
	KpD = SDL3.SDLK_KP_D,
	KpE = SDL3.SDLK_KP_E,
	KpF = SDL3.SDLK_KP_F,
	KpXor = SDL3.SDLK_KP_XOR,
	KpPower = SDL3.SDLK_KP_POWER,
	KpPercent = SDL3.SDLK_KP_PERCENT,
	KpLess = SDL3.SDLK_KP_LESS,
	KpGreater = SDL3.SDLK_KP_GREATER,
	KpAmpersand = SDL3.SDLK_KP_AMPERSAND,
	KpDblampersand = SDL3.SDLK_KP_DBLAMPERSAND,
	KpVerticalbar = SDL3.SDLK_KP_VERTICALBAR,
	KpDblverticalbar = SDL3.SDLK_KP_DBLVERTICALBAR,
	KpColon = SDL3.SDLK_KP_COLON,
	KpHash = SDL3.SDLK_KP_HASH,
	KpSpace = SDL3.SDLK_KP_SPACE,
	KpAt = SDL3.SDLK_KP_AT,
	KpExclam = SDL3.SDLK_KP_EXCLAM,
	KpMemstore = SDL3.SDLK_KP_MEMSTORE,
	KpMemrecall = SDL3.SDLK_KP_MEMRECALL,
	KpMemclear = SDL3.SDLK_KP_MEMCLEAR,
	KpMemadd = SDL3.SDLK_KP_MEMADD,
	KpMemsubtract = SDL3.SDLK_KP_MEMSUBTRACT,
	KpMemmultiply = SDL3.SDLK_KP_MEMMULTIPLY,
	KpMemdivide = SDL3.SDLK_KP_MEMDIVIDE,
	KpPlusMinus = SDL3.SDLK_KP_PLUSMINUS,
	KpClear = SDL3.SDLK_KP_CLEAR,
	KpClearentry = SDL3.SDLK_KP_CLEARENTRY,
	KpBinary = SDL3.SDLK_KP_BINARY,
	KpOctal = SDL3.SDLK_KP_OCTAL,
	KpDecimal = SDL3.SDLK_KP_DECIMAL,
	KpHexadecimal = SDL3.SDLK_KP_HEXADECIMAL,
	LeftControl = SDL3.SDLK_LCTRL,
	LeftShift = SDL3.SDLK_LSHIFT,
	LeftAlt = SDL3.SDLK_LALT,
	LeftGui = SDL3.SDLK_LGUI,
	RightControl = SDL3.SDLK_RCTRL,
	RightShift = SDL3.SDLK_RSHIFT,
	RightAlt = SDL3.SDLK_RALT,
	RightGui = SDL3.SDLK_RGUI,
	Mode = SDL3.SDLK_MODE,
	Sleep = SDL3.SDLK_SLEEP,
	Wake = SDL3.SDLK_WAKE,
	ChannelIncrement = SDL3.SDLK_CHANNEL_INCREMENT,
	ChannelDecrement = SDL3.SDLK_CHANNEL_DECREMENT,
	MediaPlay = SDL3.SDLK_MEDIA_PLAY,
	MediaPause = SDL3.SDLK_MEDIA_PAUSE,
	MediaRecord = SDL3.SDLK_MEDIA_RECORD,
	MediaFastForward = SDL3.SDLK_MEDIA_FAST_FORWARD,
	MediaRewind = SDL3.SDLK_MEDIA_REWIND,
	MediaNextTrack = SDL3.SDLK_MEDIA_NEXT_TRACK,
	MediaPreviousTrack = SDL3.SDLK_MEDIA_PREVIOUS_TRACK,
	MediaStop = SDL3.SDLK_MEDIA_STOP,
	MediaEject = SDL3.SDLK_MEDIA_EJECT,
	MediaPlayPause = SDL3.SDLK_MEDIA_PLAY_PAUSE,
	MediaSelect = SDL3.SDLK_MEDIA_SELECT,
	AcNew = SDL3.SDLK_AC_NEW,
	AcOpen = SDL3.SDLK_AC_OPEN,
	AcClose = SDL3.SDLK_AC_CLOSE,
	AcExit = SDL3.SDLK_AC_EXIT,
	AcSave = SDL3.SDLK_AC_SAVE,
	AcPrint = SDL3.SDLK_AC_PRINT,
	AcProperties = SDL3.SDLK_AC_PROPERTIES,
	AcSearch = SDL3.SDLK_AC_SEARCH,
	AcHome = SDL3.SDLK_AC_HOME,
	AcBack = SDL3.SDLK_AC_BACK,
	AcForward = SDL3.SDLK_AC_FORWARD,
	AcStop = SDL3.SDLK_AC_STOP,
	AcRefresh = SDL3.SDLK_AC_REFRESH,
	AcBookmarks = SDL3.SDLK_AC_BOOKMARKS,
	Softleft = SDL3.SDLK_SOFTLEFT,
	Softright = SDL3.SDLK_SOFTRIGHT,
	Call = SDL3.SDLK_CALL,
	Endcall = SDL3.SDLK_ENDCALL,
}

[Flags]
public enum SDL_Keymod : ushort
{
	None = SDL3.SDL_KMOD_NONE,
	LeftShift = SDL3.SDL_KMOD_LSHIFT,
	RightShift = SDL3.SDL_KMOD_RSHIFT,
	LeftControl = SDL3.SDL_KMOD_LCTRL,
	RightControl = SDL3.SDL_KMOD_RCTRL,
	LeftAlt = SDL3.SDL_KMOD_LALT,
	RightAlt = SDL3.SDL_KMOD_RALT,
	LeftGui = SDL3.SDL_KMOD_LGUI,
	RightGui = SDL3.SDL_KMOD_RGUI,
	Num = SDL3.SDL_KMOD_NUM,
	Caps = SDL3.SDL_KMOD_CAPS,
	Mode = SDL3.SDL_KMOD_MODE,
	Scroll = SDL3.SDL_KMOD_SCROLL,
	Ctrl = SDL3.SDL_KMOD_CTRL,
	Shift = SDL3.SDL_KMOD_SHIFT,
	Alt = SDL3.SDL_KMOD_ALT,
	Gui = SDL3.SDL_KMOD_GUI,
}

[Flags]
public enum SDL_MessageBoxFlags : uint
{
	Error = SDL3.SDL_MESSAGEBOX_ERROR,
	Warning = SDL3.SDL_MESSAGEBOX_WARNING,
	Information = SDL3.SDL_MESSAGEBOX_INFORMATION,
	ButtonsLeftToRight = SDL3.SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT,
	ButtonsRightToLeft = SDL3.SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT,
}

[Flags]
public enum SDL_MessageBoxButtonFlags : uint
{
	ReturnKeyDefault = SDL3.SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT,
	EscapeKeyDefault = SDL3.SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT,
}

public enum SDL_MouseID : uint
{
}

public enum SDL_PenID : uint
{
}

[Flags]
public enum SDL_PenInputFlags : uint
{
}

public enum SDL_PropertiesID : uint
{
}

public enum SDL_SensorID : uint
{
}

[Flags]
public enum SDL_SurfaceFlags : uint
{
	Preallocated = SDL3.SDL_SURFACE_PREALLOCATED,
	LockNeeded = SDL3.SDL_SURFACE_LOCK_NEEDED,
	Locked = SDL3.SDL_SURFACE_LOCKED,
	SimdAligned = SDL3.SDL_SURFACE_SIMD_ALIGNED,
}

public enum SDL_ThreadID : ulong
{
}

public enum SDL_TimerID : uint
{
}

public enum SDL_TouchID : ulong
{
}

public enum SDL_FingerID : ulong
{
}

public enum SDL_DisplayID : uint
{
}

public enum SDL_WindowID : uint
{
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_AudioStream(nint value) : IEquatable<SDL_AudioStream>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_AudioStream Null => new(0);
	public static implicit operator nint(SDL_AudioStream value) => value.Value;
	public static implicit operator SDL_AudioStream(nint value) => new(value);
	public static bool operator ==(SDL_AudioStream left, SDL_AudioStream right) => left.Value == right.Value;
	public static bool operator !=(SDL_AudioStream left, SDL_AudioStream right) => left.Value != right.Value;
	public static bool operator ==(SDL_AudioStream left, nint right) => left.Value == right;
	public static bool operator !=(SDL_AudioStream left, nint right) => left.Value != right;
	public bool Equals(SDL_AudioStream other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_AudioStream other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_AudioStream)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Camera(nint value) : IEquatable<SDL_Camera>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Camera Null => new(0);
	public static implicit operator nint(SDL_Camera value) => value.Value;
	public static implicit operator SDL_Camera(nint value) => new(value);
	public static bool operator ==(SDL_Camera left, SDL_Camera right) => left.Value == right.Value;
	public static bool operator !=(SDL_Camera left, SDL_Camera right) => left.Value != right.Value;
	public static bool operator ==(SDL_Camera left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Camera left, nint right) => left.Value != right;
	public bool Equals(SDL_Camera other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Camera other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Camera)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Gamepad(nint value) : IEquatable<SDL_Gamepad>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Gamepad Null => new(0);
	public static implicit operator nint(SDL_Gamepad value) => value.Value;
	public static implicit operator SDL_Gamepad(nint value) => new(value);
	public static bool operator ==(SDL_Gamepad left, SDL_Gamepad right) => left.Value == right.Value;
	public static bool operator !=(SDL_Gamepad left, SDL_Gamepad right) => left.Value != right.Value;
	public static bool operator ==(SDL_Gamepad left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Gamepad left, nint right) => left.Value != right;
	public bool Equals(SDL_Gamepad other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Gamepad other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Gamepad)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Haptic(nint value) : IEquatable<SDL_Haptic>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Haptic Null => new(0);
	public static implicit operator nint(SDL_Haptic value) => value.Value;
	public static implicit operator SDL_Haptic(nint value) => new(value);
	public static bool operator ==(SDL_Haptic left, SDL_Haptic right) => left.Value == right.Value;
	public static bool operator !=(SDL_Haptic left, SDL_Haptic right) => left.Value != right.Value;
	public static bool operator ==(SDL_Haptic left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Haptic left, nint right) => left.Value != right;
	public bool Equals(SDL_Haptic other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Haptic other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Haptic)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_hid_device(nint value) : IEquatable<SDL_hid_device>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_hid_device Null => new(0);
	public static implicit operator nint(SDL_hid_device value) => value.Value;
	public static implicit operator SDL_hid_device(nint value) => new(value);
	public static bool operator ==(SDL_hid_device left, SDL_hid_device right) => left.Value == right.Value;
	public static bool operator !=(SDL_hid_device left, SDL_hid_device right) => left.Value != right.Value;
	public static bool operator ==(SDL_hid_device left, nint right) => left.Value == right;
	public static bool operator !=(SDL_hid_device left, nint right) => left.Value != right;
	public bool Equals(SDL_hid_device other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_hid_device other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_hid_device)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_IOStream(nint value) : IEquatable<SDL_IOStream>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_IOStream Null => new(0);
	public static implicit operator nint(SDL_IOStream value) => value.Value;
	public static implicit operator SDL_IOStream(nint value) => new(value);
	public static bool operator ==(SDL_IOStream left, SDL_IOStream right) => left.Value == right.Value;
	public static bool operator !=(SDL_IOStream left, SDL_IOStream right) => left.Value != right.Value;
	public static bool operator ==(SDL_IOStream left, nint right) => left.Value == right;
	public static bool operator !=(SDL_IOStream left, nint right) => left.Value != right;
	public bool Equals(SDL_IOStream other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_IOStream other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_IOStream)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Joystick(nint value) : IEquatable<SDL_Joystick>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Joystick Null => new(0);
	public static implicit operator nint(SDL_Joystick value) => value.Value;
	public static implicit operator SDL_Joystick(nint value) => new(value);
	public static bool operator ==(SDL_Joystick left, SDL_Joystick right) => left.Value == right.Value;
	public static bool operator !=(SDL_Joystick left, SDL_Joystick right) => left.Value != right.Value;
	public static bool operator ==(SDL_Joystick left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Joystick left, nint right) => left.Value != right;
	public bool Equals(SDL_Joystick other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Joystick other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Joystick)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Cursor(nint value) : IEquatable<SDL_Cursor>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Cursor Null => new(0);
	public static implicit operator nint(SDL_Cursor value) => value.Value;
	public static implicit operator SDL_Cursor(nint value) => new(value);
	public static bool operator ==(SDL_Cursor left, SDL_Cursor right) => left.Value == right.Value;
	public static bool operator !=(SDL_Cursor left, SDL_Cursor right) => left.Value != right.Value;
	public static bool operator ==(SDL_Cursor left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Cursor left, nint right) => left.Value != right;
	public bool Equals(SDL_Cursor other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Cursor other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Cursor)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Mutex(nint value) : IEquatable<SDL_Mutex>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Mutex Null => new(0);
	public static implicit operator nint(SDL_Mutex value) => value.Value;
	public static implicit operator SDL_Mutex(nint value) => new(value);
	public static bool operator ==(SDL_Mutex left, SDL_Mutex right) => left.Value == right.Value;
	public static bool operator !=(SDL_Mutex left, SDL_Mutex right) => left.Value != right.Value;
	public static bool operator ==(SDL_Mutex left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Mutex left, nint right) => left.Value != right;
	public bool Equals(SDL_Mutex other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Mutex other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Mutex)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_RWLock(nint value) : IEquatable<SDL_RWLock>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_RWLock Null => new(0);
	public static implicit operator nint(SDL_RWLock value) => value.Value;
	public static implicit operator SDL_RWLock(nint value) => new(value);
	public static bool operator ==(SDL_RWLock left, SDL_RWLock right) => left.Value == right.Value;
	public static bool operator !=(SDL_RWLock left, SDL_RWLock right) => left.Value != right.Value;
	public static bool operator ==(SDL_RWLock left, nint right) => left.Value == right;
	public static bool operator !=(SDL_RWLock left, nint right) => left.Value != right;
	public bool Equals(SDL_RWLock other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_RWLock other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_RWLock)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Semaphore(nint value) : IEquatable<SDL_Semaphore>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Semaphore Null => new(0);
	public static implicit operator nint(SDL_Semaphore value) => value.Value;
	public static implicit operator SDL_Semaphore(nint value) => new(value);
	public static bool operator ==(SDL_Semaphore left, SDL_Semaphore right) => left.Value == right.Value;
	public static bool operator !=(SDL_Semaphore left, SDL_Semaphore right) => left.Value != right.Value;
	public static bool operator ==(SDL_Semaphore left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Semaphore left, nint right) => left.Value != right;
	public bool Equals(SDL_Semaphore other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Semaphore other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Semaphore)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Condition(nint value) : IEquatable<SDL_Condition>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Condition Null => new(0);
	public static implicit operator nint(SDL_Condition value) => value.Value;
	public static implicit operator SDL_Condition(nint value) => new(value);
	public static bool operator ==(SDL_Condition left, SDL_Condition right) => left.Value == right.Value;
	public static bool operator !=(SDL_Condition left, SDL_Condition right) => left.Value != right.Value;
	public static bool operator ==(SDL_Condition left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Condition left, nint right) => left.Value != right;
	public bool Equals(SDL_Condition other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Condition other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Condition)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Renderer(nint value) : IEquatable<SDL_Renderer>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Renderer Null => new(0);
	public static implicit operator nint(SDL_Renderer value) => value.Value;
	public static implicit operator SDL_Renderer(nint value) => new(value);
	public static bool operator ==(SDL_Renderer left, SDL_Renderer right) => left.Value == right.Value;
	public static bool operator !=(SDL_Renderer left, SDL_Renderer right) => left.Value != right.Value;
	public static bool operator ==(SDL_Renderer left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Renderer left, nint right) => left.Value != right;
	public bool Equals(SDL_Renderer other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Renderer other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Renderer)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Texture(nint value) : IEquatable<SDL_Texture>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Texture Null => new(0);
	public static implicit operator nint(SDL_Texture value) => value.Value;
	public static implicit operator SDL_Texture(nint value) => new(value);
	public static bool operator ==(SDL_Texture left, SDL_Texture right) => left.Value == right.Value;
	public static bool operator !=(SDL_Texture left, SDL_Texture right) => left.Value != right.Value;
	public static bool operator ==(SDL_Texture left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Texture left, nint right) => left.Value != right;
	public bool Equals(SDL_Texture other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Texture other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Texture)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Sensor(nint value) : IEquatable<SDL_Sensor>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Sensor Null => new(0);
	public static implicit operator nint(SDL_Sensor value) => value.Value;
	public static implicit operator SDL_Sensor(nint value) => new(value);
	public static bool operator ==(SDL_Sensor left, SDL_Sensor right) => left.Value == right.Value;
	public static bool operator !=(SDL_Sensor left, SDL_Sensor right) => left.Value != right.Value;
	public static bool operator ==(SDL_Sensor left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Sensor left, nint right) => left.Value != right;
	public bool Equals(SDL_Sensor other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Sensor other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Sensor)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_iconv_data_t(nint value) : IEquatable<SDL_iconv_data_t>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_iconv_data_t Null => new(0);
	public static implicit operator nint(SDL_iconv_data_t value) => value.Value;
	public static implicit operator SDL_iconv_data_t(nint value) => new(value);
	public static bool operator ==(SDL_iconv_data_t left, SDL_iconv_data_t right) => left.Value == right.Value;
	public static bool operator !=(SDL_iconv_data_t left, SDL_iconv_data_t right) => left.Value != right.Value;
	public static bool operator ==(SDL_iconv_data_t left, nint right) => left.Value == right;
	public static bool operator !=(SDL_iconv_data_t left, nint right) => left.Value != right;
	public bool Equals(SDL_iconv_data_t other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_iconv_data_t other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_iconv_data_t)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Storage(nint value) : IEquatable<SDL_Storage>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Storage Null => new(0);
	public static implicit operator nint(SDL_Storage value) => value.Value;
	public static implicit operator SDL_Storage(nint value) => new(value);
	public static bool operator ==(SDL_Storage left, SDL_Storage right) => left.Value == right.Value;
	public static bool operator !=(SDL_Storage left, SDL_Storage right) => left.Value != right.Value;
	public static bool operator ==(SDL_Storage left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Storage left, nint right) => left.Value != right;
	public bool Equals(SDL_Storage other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Storage other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Storage)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_SurfaceData(nint value) : IEquatable<SDL_SurfaceData>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_SurfaceData Null => new(0);
	public static implicit operator nint(SDL_SurfaceData value) => value.Value;
	public static implicit operator SDL_SurfaceData(nint value) => new(value);
	public static bool operator ==(SDL_SurfaceData left, SDL_SurfaceData right) => left.Value == right.Value;
	public static bool operator !=(SDL_SurfaceData left, SDL_SurfaceData right) => left.Value != right.Value;
	public static bool operator ==(SDL_SurfaceData left, nint right) => left.Value == right;
	public static bool operator !=(SDL_SurfaceData left, nint right) => left.Value != right;
	public bool Equals(SDL_SurfaceData other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_SurfaceData other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_SurfaceData)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Thread(nint value) : IEquatable<SDL_Thread>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Thread Null => new(0);
	public static implicit operator nint(SDL_Thread value) => value.Value;
	public static implicit operator SDL_Thread(nint value) => new(value);
	public static bool operator ==(SDL_Thread left, SDL_Thread right) => left.Value == right.Value;
	public static bool operator !=(SDL_Thread left, SDL_Thread right) => left.Value != right.Value;
	public static bool operator ==(SDL_Thread left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Thread left, nint right) => left.Value != right;
	public bool Equals(SDL_Thread other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Thread other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Thread)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_DisplayModeData(nint value) : IEquatable<SDL_DisplayModeData>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_DisplayModeData Null => new(0);
	public static implicit operator nint(SDL_DisplayModeData value) => value.Value;
	public static implicit operator SDL_DisplayModeData(nint value) => new(value);
	public static bool operator ==(SDL_DisplayModeData left, SDL_DisplayModeData right) => left.Value == right.Value;
	public static bool operator !=(SDL_DisplayModeData left, SDL_DisplayModeData right) => left.Value != right.Value;
	public static bool operator ==(SDL_DisplayModeData left, nint right) => left.Value == right;
	public static bool operator !=(SDL_DisplayModeData left, nint right) => left.Value != right;
	public bool Equals(SDL_DisplayModeData other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_DisplayModeData other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_DisplayModeData)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_Window(nint value) : IEquatable<SDL_Window>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_Window Null => new(0);
	public static implicit operator nint(SDL_Window value) => value.Value;
	public static implicit operator SDL_Window(nint value) => new(value);
	public static bool operator ==(SDL_Window left, SDL_Window right) => left.Value == right.Value;
	public static bool operator !=(SDL_Window left, SDL_Window right) => left.Value != right.Value;
	public static bool operator ==(SDL_Window left, nint right) => left.Value == right;
	public static bool operator !=(SDL_Window left, nint right) => left.Value != right;
	public bool Equals(SDL_Window other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_Window other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_Window)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct SDL_GLContext(nint value) : IEquatable<SDL_GLContext>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static SDL_GLContext Null => new(0);
	public static implicit operator nint(SDL_GLContext value) => value.Value;
	public static implicit operator SDL_GLContext(nint value) => new(value);
	public static bool operator ==(SDL_GLContext left, SDL_GLContext right) => left.Value == right.Value;
	public static bool operator !=(SDL_GLContext left, SDL_GLContext right) => left.Value != right.Value;
	public static bool operator ==(SDL_GLContext left, nint right) => left.Value == right;
	public static bool operator !=(SDL_GLContext left, nint right) => left.Value != right;
	public bool Equals(SDL_GLContext other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is SDL_GLContext other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(SDL_GLContext)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct tagMSG(nint value) : IEquatable<tagMSG>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static tagMSG Null => new(0);
	public static implicit operator nint(tagMSG value) => value.Value;
	public static implicit operator tagMSG(nint value) => new(value);
	public static bool operator ==(tagMSG left, tagMSG right) => left.Value == right.Value;
	public static bool operator !=(tagMSG left, tagMSG right) => left.Value != right.Value;
	public static bool operator ==(tagMSG left, nint right) => left.Value == right;
	public static bool operator !=(tagMSG left, nint right) => left.Value != right;
	public bool Equals(tagMSG other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is tagMSG other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(tagMSG)} [0x{Value.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct _XEvent(nint value) : IEquatable<_XEvent>
{
	public readonly nint Value = value;
	public bool IsNull => Value == 0;
	public bool IsNotNull => Value != 0;
	public static _XEvent Null => new(0);
	public static implicit operator nint(_XEvent value) => value.Value;
	public static implicit operator _XEvent(nint value) => new(value);
	public static bool operator ==(_XEvent left, _XEvent right) => left.Value == right.Value;
	public static bool operator !=(_XEvent left, _XEvent right) => left.Value != right.Value;
	public static bool operator ==(_XEvent left, nint right) => left.Value == right;
	public static bool operator !=(_XEvent left, nint right) => left.Value != right;
	public bool Equals(_XEvent other) => Value.Equals(other.Value);
	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj) => (obj is _XEvent other) && Equals(other);
	/// <inheritdoc/>
	public override int GetHashCode() => Value.GetHashCode();
	private string DebuggerDisplay => $"{nameof(_XEvent)} [0x{Value.ToString("X")}]";
}

