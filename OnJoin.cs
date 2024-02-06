using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000010 RID: 16
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerEnteredRoom", 0)]
	internal class OnJoin : HarmonyPatch
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00011A90 File Offset: 0x0000FC90
		private static void Prefix(Player newPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 1)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player), ref num, ref num2, ref num3, newPlayer, OnJoin.HostAssemblyEvidencegetFailedAssemblyInfo[num]);
			}
			num2 = 0;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		public OnJoin()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnJoin), ref num, ref num2, ref num3, this, OnJoin.HostAssemblyEvidencegetFailedAssemblyInfo[num]);
			}
			num2 = 1;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00011AF8 File Offset: 0x0000FCF8
		private static void CurrentConfiggetCount(ref int A_0, ref int A_1, ref int A_2, Player A_3)
		{
			NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + A_3.NickName + " Joined Lobby");
			A_1 = 1;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00011B30 File Offset: 0x0000FD30
		private static void CheckSubKeyWritePermissionSetServerIdentity(ref int A_0, ref int A_1, ref int A_2, OnJoin A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00011B54 File Offset: 0x0000FD54
		// Note: this type is marked as 'beforefieldinit'.
		static OnJoin()
		{
			OnJoin.PreAllocatedOverlappedUCOMIBindCtx();
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00011B68 File Offset: 0x0000FD68
		private static void PreAllocatedOverlappedUCOMIBindCtx()
		{
			OnJoin.HostAssemblyEvidencegetFailedAssemblyInfo = new IntPtr[2];
			OnJoin.HostAssemblyEvidencegetFailedAssemblyInfo[0] = ldftn(CurrentConfiggetCount);
			OnJoin.HostAssemblyEvidencegetFailedAssemblyInfo[1] = ldftn(CheckSubKeyWritePermissionSetServerIdentity);
		}

		// Token: 0x0400006E RID: 110
		private static IntPtr[] HostAssemblyEvidencegetFailedAssemblyInfo;
	}
}
