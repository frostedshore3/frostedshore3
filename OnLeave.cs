using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000011 RID: 17
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerLeftRoom", 0)]
	internal class OnLeave : HarmonyPatch
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		private static void Prefix(Player otherPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 5)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref flag, ref flag2, otherPlayer, OnLeave.getUseSaltDispatchMessage[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		public OnLeave()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnLeave), ref num, ref num2, ref num3, this, OnLeave.getUseSaltDispatchMessage[num]);
			}
			num2 = 5;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00011C14 File Offset: 0x0000FE14
		private static void setKeyStoreSingle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			bool flag = A_5 != PhotonNetwork.LocalPlayer;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 3 + 1;
			A_0 = num;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00011C80 File Offset: 0x0000FE80
		private static void RuntimeMethodInfoDocType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00011C98 File Offset: 0x0000FE98
		private static void SuccessRevokeObjectBound(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=yellow>[ROOM]: YOU ARE NOW MASTER CLIENT!</color>");
			A_1 = 5;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		private static void UseSoapFormatOrdinalIgnoreCase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + A_5.NickName + " Left Lobby");
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			A_4 = isMasterClient;
			int num = ((!A_4) ? 1 : 0) * 1 + 2;
			A_0 = num;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00011D3C File Offset: 0x0000FF3C
		private static void AssemblyRefMissingMemberException(ref int A_0, ref int A_1, ref int A_2, OnLeave A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00011D60 File Offset: 0x0000FF60
		private static void APPXFLAGSINITIALIZEDGetLastWriteTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00011D78 File Offset: 0x0000FF78
		// Note: this type is marked as 'beforefieldinit'.
		static OnLeave()
		{
			OnLeave.CMSSECTIONIDPERMISSIONSETSECTIONGetEvents();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00011D8C File Offset: 0x0000FF8C
		private static void CMSSECTIONIDPERMISSIONSETSECTIONGetEvents()
		{
			OnLeave.getUseSaltDispatchMessage = new IntPtr[6];
			OnLeave.getUseSaltDispatchMessage[0] = ldftn(setKeyStoreSingle);
			OnLeave.getUseSaltDispatchMessage[1] = ldftn(UseSoapFormatOrdinalIgnoreCase);
			OnLeave.getUseSaltDispatchMessage[2] = ldftn(SuccessRevokeObjectBound);
			OnLeave.getUseSaltDispatchMessage[3] = ldftn(RuntimeMethodInfoDocType);
			OnLeave.getUseSaltDispatchMessage[4] = ldftn(APPXFLAGSINITIALIZEDGetLastWriteTime);
			OnLeave.getUseSaltDispatchMessage[5] = ldftn(AssemblyRefMissingMemberException);
		}

		// Token: 0x0400006F RID: 111
		private static IntPtr[] getUseSaltDispatchMessage;
	}
}
