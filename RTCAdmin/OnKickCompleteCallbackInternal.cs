﻿using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000247 RID: 583
	// (Invoke) Token: 0x06001017 RID: 4119
	[Token(Token = "0x2000247")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnKickCompleteCallbackInternal(ref KickCompleteCallbackInfoInternal data);
}
