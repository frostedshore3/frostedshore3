using System;
using System.Collections.Generic;
using System.IO;
using dark.efijiPOIWikjek;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using GorillaTag;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using ShibaGTTemplate.UI;
using ShibaGTTemplate.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000012 RID: 18
	internal class Mods : MonoBehaviour
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00011E10 File Offset: 0x00010010
		private static void DNNdGetGuid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_1 = 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00011E50 File Offset: 0x00010050
		private static void getSkipVerificationAddSeconds(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			bool flag = A_3.distance == A_4.distance;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 223;
			A_0 = num;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00011ED8 File Offset: 0x000100D8
		private static void IsNullTokenTryGetBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Normal";
			Mods.flySpeed = 15f;
			bool flag = Mods.TurnGay == 2;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 364;
			A_0 = num;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011F60 File Offset: 0x00010160
		private static void BrowserRefreshcFileNameeFixedBuffer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 100;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00011F9C File Offset: 0x0001019C
		private static void TraceFormatsetMinimumLevel(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 3;
			A_2 = 279;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00011FC0 File Offset: 0x000101C0
		private static void mpublicKeyBlobGetEncoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 7;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 374;
			A_0 = num;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00012024 File Offset: 0x00010224
		private static void bstrDescriptionDateTimeStyles(ref int A_0, ref int A_1, ref int A_2, ref VRRig[] A_3, ref int A_4, ref VRRig A_5)
		{
			VRRig[] array = (VRRig[])Object.FindObjectsOfType(typeof(VRRig));
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 291;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00012078 File Offset: 0x00010278
		private static void RegistryViewSystemEnvironment(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			A_5.enabled = true;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -5 + 157;
			A_0 = num2;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000120EC File Offset: 0x000102EC
		private static void PopipoprRuntimeInformation(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 79;
			A_0 = num;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00012128 File Offset: 0x00010328
		public static void FrontFlip()
		{
			int num = 95;
			int num2 = 95;
			num2 = 95;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 95;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00012160 File Offset: 0x00010360
		private static void ArgumentItemNotExistgetIsOut(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 8;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 177;
			A_0 = num;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000121C4 File Offset: 0x000103C4
		public static void ColorWhite()
		{
			int num = 427;
			int num2 = 427;
			num2 = 427;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 427;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00012208 File Offset: 0x00010408
		private static void getTrackResurrectiongetResources(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			Transform child = A_5.GetChild(A_6);
			A_7 = child;
			int num = ((!A_7.gameObject.name.Contains("Anchor")) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001228C File Offset: 0x0001048C
		private static void IResourceGrovelerCspParameters(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			GameObject gameObject = new GameObject("Line");
			A_7 = gameObject;
			LineRenderer lineRenderer = A_7.AddComponent<LineRenderer>();
			A_8 = lineRenderer;
			A_8.startWidth = 0.025f;
			A_8.endWidth = 0.025f;
			A_8.positionCount = 2;
			A_8.useWorldSpace = true;
			A_8.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
			A_8.SetPosition(1, A_5.transform.position);
			A_8.material.shader = Shader.Find("GUI/Text Shader");
			bool changingColors = Mods.ChangingColors;
			A_9 = changingColors;
			int num = ((!A_9) ? 1 : 0) * 1 + 68;
			A_0 = num;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000123DC File Offset: 0x000105DC
		private static void IsTypeDefAllowLeadingWhite(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			A_0 = 306;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001240C File Offset: 0x0001060C
		private static void GetDomainRemotingTimeoutException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 6 + 333;
			A_0 = num;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000124AC File Offset: 0x000106AC
		private static void CommonOemLinksMoveTimerToCorrectList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = !A_18;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 358;
			A_0 = num;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00012510 File Offset: 0x00010710
		private static void ExceptionHandlingClauseMonday(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < Mods.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 462;
			A_0 = num;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00012578 File Offset: 0x00010778
		private static void NameIdentifierThisCall(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			A_0 = 236;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000125AC File Offset: 0x000107AC
		private static void VBByValStrMarshalerVerbose(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Normal";
			Mods.flySpeed = 15f;
			bool flag = Mods.TurnGay == 10;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 380;
			A_0 = num;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00012634 File Offset: 0x00010834
		private static void PlatformsThing(bool invis, bool sticky)
		{
			int num = 428;
			int num2 = 428;
			num2 = 428;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 428;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000126B0 File Offset: 0x000108B0
		private static void GetDayOfMonthArabicNumber(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000126C8 File Offset: 0x000108C8
		private static void DateTimeResultsetApartmentState(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool activeSelf = A_7.gameObject.activeSelf;
			A_8 = activeSelf;
			int num = ((!A_8) ? 1 : 0) * 20 + 18;
			A_0 = num;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00012738 File Offset: 0x00010938
		private static void MapToCollectionAdapterComObject(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 102;
			A_0 = num;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000127C4 File Offset: 0x000109C4
		private static void getIsCompatibilityBehaviorDefinedPercentGroupSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.3f";
			bool flag = Mods.DickIsTiny == 4;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 169;
			A_0 = num;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00012868 File Offset: 0x00010A68
		private static void RCDirectorySeparatorChar(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			Mods.pointer.transform.position = A_4.point;
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 351;
			A_0 = num;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000128E0 File Offset: 0x00010AE0
		private static void AllowPartiallyTrustedCallersAttributeMemberInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.funn = GameObject.Find("Third Person Camera");
			Mods.funn.SetActive(false);
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 401;
			A_0 = num;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00012968 File Offset: 0x00010B68
		private static void ToStringHelperFuncReadAllBytes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			GorillaTagger.Instance.offlineVRRig.rightHandTransform.position = A_5.transform.position;
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 126;
			A_0 = num;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000129D8 File Offset: 0x00010BD8
		private static void RelaxedSignaturesetSelfAffectingThreading(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Mods.DickIsTiny++;
			bool flag = Mods.DickIsTiny == 0;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 161;
			A_0 = num;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00012A4C File Offset: 0x00010C4C
		private static void ToDecimalMuiResourceTypeIdStringStringIds(ref int A_0, ref int A_1, ref int A_2, ref GradientColorKey[] A_3, ref Gradient A_4, ref float A_5, ref Color A_6, ref bool A_7, ref bool A_8)
		{
			A_1 = 0;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00012A64 File Offset: 0x00010C64
		private static void getIsContextfulTKINDENUM(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.settingsbuttons[0].enabled = new bool?(false);
			WristMenu.buttons[0].enabled = new bool?(false);
			Mods.inSettings = !Mods.inSettings;
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00012ADC File Offset: 0x00010CDC
		private static void setCheckExecutionRightsgetKeyName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			((IDisposable)A_16).Dispose();
			A_1 = 3;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00012B04 File Offset: 0x00010D04
		private static void LogMessageCOREDIRECTORYNOTFOUND(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 1;
			A_2 = 63;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00012B28 File Offset: 0x00010D28
		private static void GetSourcessetShadowCopyFiles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1f";
			bool flag = Mods.DickIsTiny == 7;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 175;
			A_0 = num;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00012BCC File Offset: 0x00010DCC
		private static void CompressedStackSwitcherAccountOperator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.funn = GameObject.Find("CameraTablet(Clone)");
			Mods.funn.SetActive(false);
			A_1 = 0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00012C04 File Offset: 0x00010E04
		private static void ResetColorFirstChanceExceptionEventArgs(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance == A_4.distance;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 233;
			A_0 = num;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00012C70 File Offset: 0x00010E70
		private static void TXTSSystemAclProtected(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			ButtonInfo buttonInfo = A_8.Current;
			A_9 = buttonInfo;
			bool flag = A_9.buttonText == A_7;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 419;
			A_0 = num;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00012D00 File Offset: 0x00010F00
		private static void getBlockSizeValueRemoveAudit(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 285;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00012D18 File Offset: 0x00010F18
		private static void EventSourceCreatedEventArgsGetGenericParameterConstraints(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00012D30 File Offset: 0x00010F30
		private static void CallConvThiscallJapaneseCalendar(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_0 = 72;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00012D48 File Offset: 0x00010F48
		private static void TimeZoneInfoOpcodes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00012D60 File Offset: 0x00010F60
		private static void IntArraygetAbbreviatedDayNames(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Vector3 vector = A_3.point - Player.Instance.rightControllerTransform.position;
			A_8 = vector;
			Vector3 normalized = A_8.normalized;
			A_9 = normalized;
			Physics.gravity = A_9 * 9.81f;
			A_0 = 221;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00012DDC File Offset: 0x00010FDC
		private static void AppContextDefaultValuesIsNetFxLegacySecurityPolicy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				GorillaTagger.Instance.leftHandTransform.position,
				GorillaTagger.Instance.leftHandTransform.rotation,
				4f,
				100f,
				true,
				false
			});
			Mods.FlushRemoteProceduralCalls();
			Mods.Deli = Time.time + 0.1f;
			A_1 = 0;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00012EAC File Offset: 0x000110AC
		private static void TKINDINTERFACEObjectDisposedException(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player player = A_3[A_4];
			A_5 = player;
			PhotonNetwork.CurrentRoom.StorePlayer(A_5);
			PhotonNetwork.CurrentRoom.Players.Remove(A_5.ActorNumber);
			PhotonNetwork.OpRemoveCompleteCacheOfPlayer(A_5.ActorNumber);
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 79;
			A_0 = num2;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00012F74 File Offset: 0x00011174
		private static void getQuotaDiscretionaryAclProtected(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.2f";
			bool flag = Mods.DickIsTiny == 15;
			A_19 = flag;
			int num = ((!A_19) ? 1 : 0) * 1 + 191;
			A_0 = num;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00013018 File Offset: 0x00011218
		private static void SetupInformationRoundtripKind(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 258;
			A_0 = num;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00013074 File Offset: 0x00011274
		private static void HebrewErasetMonthNames(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 459;
			A_0 = num;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000130D8 File Offset: 0x000112D8
		private static void EncodedEnumTypeGO(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			A_1 = 0;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000130F0 File Offset: 0x000112F0
		private static void setDeformatterAlgorithmListDirectory(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string text = A_5[A_6];
			A_7 = text;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.settingsbuttons.GetEnumerator();
			A_8 = enumerator;
			A_0 = 417;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00013148 File Offset: 0x00011348
		private static void TokenOriginMuiResourceMapEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position = A_5.transform.position + new Vector3(0f, 1f, 0f);
			GorillaTagger.Instance.myVRRig.transform.position = A_5.transform.position + new Vector3(0f, 1f, 0f);
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_10 = gameObject;
			Object.Destroy(A_10.GetComponent<Rigidbody>());
			Object.Destroy(A_10.GetComponent<SphereCollider>());
			A_10.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_10.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_11 = gameObject2;
			Object.Destroy(A_11.GetComponent<Rigidbody>());
			Object.Destroy(A_11.GetComponent<SphereCollider>());
			A_11.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_11.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool changingColors = Mods.ChangingColors;
			A_12 = changingColors;
			int num = ((!A_12) ? 1 : 0) * 1 + 86;
			A_0 = num;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00013358 File Offset: 0x00011558
		private static void AllowEventSourceOverridegetEvidenceObject(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool flag = A_10 < A_7.childCount;
			A_23 = flag;
			int num = (A_23 ? 1 : 0) * -18 + 37;
			A_0 = num;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000133C8 File Offset: 0x000115C8
		private static void DateUnknown(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000133E0 File Offset: 0x000115E0
		private static void GetFieldCollectFromServerContext(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 412;
			A_0 = num;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00013428 File Offset: 0x00011628
		private static void GetHostEnumeratorUri(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_14 = array;
			A_14[0].color = Mods.FirstColor;
			A_14[0].time = 0f;
			A_14[1].color = Mods.FirstColor;
			A_14[1].time = 0.3f;
			A_14[2].color = Mods.SecondColor;
			A_14[2].time = 0.6f;
			A_14[3].color = Mods.SecondColor;
			A_14[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_15 = colorChanger;
			A_15.colors = new Gradient
			{
				colorKeys = A_14
			};
			A_15.Start();
			A_0 = 148;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00013594 File Offset: 0x00011794
		public static void CheckpointMonke()
		{
			int num = 132;
			int num2 = 132;
			num2 = 132;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag4;
				bool flag5;
				bool flag6;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				bool flag7;
				GradientColorKey[] array3;
				ColorChanger colorChanger3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref array, ref colorChanger, ref flag4, ref flag5, ref flag6, ref array2, ref colorChanger2, ref flag7, ref array3, ref colorChanger3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 132;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000135F0 File Offset: 0x000117F0
		private static void DeploymentStrongNameIdentityPermissionAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			Directory.CreateDirectory("TemplatePrefs");
			File.WriteAllLines("TemplatePrefs\\templateSavedPrefs.txt", A_4);
			A_1 = 0;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00013628 File Offset: 0x00011828
		private static void UnwrapGetHashFromBlob(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 65;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00013664 File Offset: 0x00011864
		private static void XmlElementPOLICYCREATESECRET(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * 500f;
			Mods.Fix = true;
			Mods.Jumpthing = Time.time + 0.5f;
			A_0 = 205;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000136CC File Offset: 0x000118CC
		private static void HashCollisionThresholdTimeZoneUsed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000136E4 File Offset: 0x000118E4
		private static void OtherNotAssignedFaultCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * -75f;
			A_1 = 0;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00013734 File Offset: 0x00011934
		private static void AreAccessRulesCanonicalDecryptValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001374C File Offset: 0x0001194C
		private static void getRelativeSearchPathCausalityRelation(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			A_1 = 0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00013780 File Offset: 0x00011980
		private static void EnvironmentBITONLY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000137B0 File Offset: 0x000119B0
		private static void getAccessEntriesgetMaxGeneration(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool flag = true;
			A_22 = flag;
			int num = ((!A_22) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001380C File Offset: 0x00011A0C
		private static void setWriteTimeoutgetFactory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			Mods.TurnGay++;
			bool flag = Mods.TurnGay == 0;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 360;
			A_0 = num;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00013880 File Offset: 0x00011A80
		private static void getTypesCMSASSEMBLYREFERENCEFLAGCULTUREWILDCARDED(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1f";
			bool flag = Mods.DickIsTiny == 1;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 163;
			A_0 = num;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00013924 File Offset: 0x00011B24
		private static void SynchronizedListNoInlining(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Faster";
			Mods.flySpeed = 40f;
			bool flag = Mods.TurnGay == 4;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 368;
			A_0 = num;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000139AC File Offset: 0x00011BAC
		private static void getAvailableFreeSpaceSIDANDATTRIBUTES(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].enabled = new bool?(false);
			WristMenu.DestroyMenu();
			bool flag = Mods.TurnGay > 44;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 356;
			A_0 = num;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00013A34 File Offset: 0x00011C34
		private static void EmptyReadOnlyDictionaryInternalgetDefaultRequestSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			bool changingColors = Mods.ChangingColors;
			A_10 = changingColors;
			int num = ((!A_10) ? 1 : 0) * 1 + 335;
			A_0 = num;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00013A90 File Offset: 0x00011C90
		private static void PostconditiongetLastWriteTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 433;
			A_0 = num;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00013AEC File Offset: 0x00011CEC
		private static void WindowsBuiltInRolecbSizeVft(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_24 = flag;
			int num2 = (A_24 ? 1 : 0) * -25 + 40;
			A_0 = num2;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00013B7C File Offset: 0x00011D7C
		private static void CMSHASHDIGESTMETHODSHAbucket(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = Time.time > Mods.Jumpthing;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 200;
			A_0 = num;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00013BE0 File Offset: 0x00011DE0
		private static void GetFieldFromHandleAdjustGroups(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_1 = 0;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00013BF8 File Offset: 0x00011DF8
		private static void SystemAlarmCallbackDP(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -5 + 157;
			A_0 = num;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00013C34 File Offset: 0x00011E34
		private static void getIsArrayBackPropAction(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			bool changingColors = Mods.ChangingColors;
			A_5 = changingColors;
			int num = ((!A_5) ? 1 : 0) * 1 + 329;
			A_0 = num;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00013CE4 File Offset: 0x00011EE4
		private static void UTFByteArraySkipVerification(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_1 = 0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00013CFC File Offset: 0x00011EFC
		public static void GrabMyHead()
		{
			int num = 266;
			int num2 = 266;
			num2 = 266;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 266;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00013D40 File Offset: 0x00011F40
		private static void HebrewNumberCdecl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 451;
			A_0 = num;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00013DBC File Offset: 0x00011FBC
		private static void SetSecurityDescriptorBinaryFormGetInt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			A_0 = 354;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00013DD4 File Offset: 0x00011FD4
		public static void LoudHandTaps()
		{
			int num = 263;
			int num2 = 263;
			num2 = 263;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 263;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00013E18 File Offset: 0x00012018
		public static void GrabRig()
		{
			int num = 244;
			int num2 = 244;
			num2 = 244;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 244;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00013E5C File Offset: 0x0001205C
		private static void GetNextCharTimerCallback(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_6 = rightGrab;
			int num = ((!A_6) ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00013EC4 File Offset: 0x000120C4
		private static void NestedPrivateReadToEndAsyncInternald(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -5 + 106;
			A_0 = num;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00013F0C File Offset: 0x0001210C
		public static void BecomeJesus()
		{
			int num = 386;
			int num2 = 386;
			num2 = 386;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 386;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00013F50 File Offset: 0x00012150
		public static void FrontRoll()
		{
			int num = 307;
			int num2 = 307;
			num2 = 307;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 307;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00013F98 File Offset: 0x00012198
		private static void FlushHexIntPtrType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaiseEventOptions A_4, ref RaiseEventOptions A_5)
		{
			bool isGay = Mods.IsGay;
			A_3 = isGay;
			int num = ((!A_3) ? 1 : 0) * 1 + 7;
			A_0 = num;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00013FF4 File Offset: 0x000121F4
		private static void fAnonymousTypeCurrentManagedThreadId(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 105;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0001400C File Offset: 0x0001220C
		private static void getLocalMaxOpaqueLength(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 411;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00014024 File Offset: 0x00012224
		private static void ArabicCLRIPropertyValueImpl(ref int A_0, ref int A_1, ref int A_2, ref VRRig[] A_3, ref int A_4, ref VRRig A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001403C File Offset: 0x0001223C
		public static void BreakAllCS()
		{
			int num = 76;
			int num2 = 76;
			num2 = 76;
			while (num2 != 0)
			{
				int num3;
				Player[] array;
				int num4;
				Player player;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&), ref num, ref num2, ref num3, ref array, ref num4, ref player, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 76;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00014078 File Offset: 0x00012278
		private static void ObjectStringAsDate(ref int A_0, ref int A_1, ref int A_2)
		{
			A_1 = 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00014090 File Offset: 0x00012290
		public static void Helicopter()
		{
			int num = 319;
			int num2 = 319;
			num2 = 319;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 319;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000140D8 File Offset: 0x000122D8
		private static void InheritedObjectAceTypeStringInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Slow";
			Mods.flySpeed = 5f;
			bool flag = Mods.TurnGay == 5;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 370;
			A_0 = num;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00014160 File Offset: 0x00012360
		private static void setAceFlagsIMPLTYPEFLAGFSOURCE(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			ButtonInfo buttonInfo = A_5.Current;
			A_6 = buttonInfo;
			bool? enabled = A_6.enabled;
			A_7 = enabled;
			bool flag = true;
			A_8 = flag;
			bool flag2 = A_7.GetValueOrDefault() == A_8 & A_7 != null;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 1 + 409;
			A_0 = num;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00014224 File Offset: 0x00012424
		private static void OnFinalReleaseReceiveHandled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001423C File Offset: 0x0001243C
		private static void ConcurrentStackIsAppEarlierThanSilverlight(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			A_1 = 0;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00014258 File Offset: 0x00012458
		private static void RemoveSpecificMemoryStream(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 444;
			A_0 = num;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000142B8 File Offset: 0x000124B8
		public static void GrabBeachBall()
		{
			int num = 251;
			int num2 = 251;
			num2 = 251;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 251;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000142FC File Offset: 0x000124FC
		private static void IFileAssociationEntryStrongNameKeyGenEx(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.sizeScale -= 0.05f;
			bool flag = Mods.sizeScale <= 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 213;
			A_0 = num;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00014378 File Offset: 0x00012578
		private static void FileAssociationEntryFieldIdgetBlockSizeValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local = GameObject.CreatePrimitive(3);
			Mods.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 436;
			A_0 = num;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00014404 File Offset: 0x00012604
		private static void TruesetWindowWidth(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_local);
			Mods.jump_right_local = null;
			Mods.once_right = false;
			Mods.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 444;
			A_0 = num;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000144C8 File Offset: 0x000126C8
		private static void InvalidOperationCannotRemoveFromStackOrQueuegetActivationArguments(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 4;
			A_2 = 414;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000144EC File Offset: 0x000126EC
		private static void RfcDeriveBytesSingleArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_0 = 149;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001455C File Offset: 0x0001275C
		private static void IsClrTypeNamespaceDynamicPartitionerForArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_local.GetComponent<Renderer>());
			Mods.jump_right_local.transform.localScale = Mods.scale;
			Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			Mods.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			Mods.once_right = true;
			Mods.once_right_false = false;
			ColorChanger colorChanger = Mods.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = Mods.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 443;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00014720 File Offset: 0x00012920
		private static void getIsHeldBinaryMethodReturnMessage(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 286;
			A_0 = num;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00014768 File Offset: 0x00012968
		private static void IsControlEvidenceType(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 114;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00014780 File Offset: 0x00012980
		private static void TKINDMAXgetLargestWindowWidth(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00014798 File Offset: 0x00012998
		private static void CustomAttributeNamedArgumentReadLinesIterator(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			bool flag = A_3.distance == A_4.distance;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 233;
			A_0 = num;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00014820 File Offset: 0x00012A20
		private static void SpecialFolderOptionMonthDatesep(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.offlineVRRig.name = "BOYMONKE221";
			GorillaComputer.instance.currentName = "BOYMONKE221";
			A_1 = 0;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00014860 File Offset: 0x00012A60
		private static void PushRangeSECURITYIMPERSONATIONLEVEL(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 276;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00014878 File Offset: 0x00012A78
		private static void ArchivableBinaryMethodReturnMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 16;
			A_20 = flag;
			int num = ((!A_20) ? 1 : 0) * 1 + 193;
			A_0 = num;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000148DC File Offset: 0x00012ADC
		private static void getIsAliveDefineUnmanagedResource(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.5f";
			bool flag = Mods.DickIsTiny == 17;
			A_22 = flag;
			int num = ((!A_22) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00014980 File Offset: 0x00012B80
		private static void ThrowOnUnmappableCharDisabledopSubtraction(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 10;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 380;
			A_0 = num;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000149E4 File Offset: 0x00012BE4
		private static void RegistryViewSystemException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 245;
			A_0 = num;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00014A40 File Offset: 0x00012C40
		private static void getMetadataSectionEntryCoClassAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 4 + 67;
			A_0 = num;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00014ACC File Offset: 0x00012CCC
		private static void ServerWellKnownEntryToEventKeywords(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			bool leftGrab = ControllerInputPoller.instance.leftGrab;
			A_11 = leftGrab;
			int num = ((!A_11) ? 1 : 0) * 8 + 227;
			A_0 = num;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00014B4C File Offset: 0x00012D4C
		private static void getIsNestedFamANDAssemgetTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.4f";
			bool flag = Mods.DickIsTiny == 5;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 171;
			A_0 = num;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00014BF0 File Offset: 0x00012DF0
		private static void getBinderIsSupported(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_11 = array;
			A_11[0].color = Mods.FirstColor;
			A_11[0].time = 0f;
			A_11[1].color = Mods.FirstColor;
			A_11[1].time = 0.3f;
			A_11[2].color = Mods.SecondColor;
			A_11[2].time = 0.6f;
			A_11[3].color = Mods.SecondColor;
			A_11[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_12 = colorChanger;
			A_12.colors = new Gradient
			{
				colorKeys = A_11
			};
			A_12.Start();
			A_0 = 337;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00014D5C File Offset: 0x00012F5C
		private static void StringTypeInfogetComparer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 5;
			A_2 = 424;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00014D80 File Offset: 0x00012F80
		private static void MemberPrimitiveTypedGetPropertySigHelper(ref int A_0, ref int A_1, ref int A_2, ref VRRig[] A_3, ref int A_4, ref VRRig A_5)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 292;
			A_0 = num;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00014DBC File Offset: 0x00012FBC
		private static void FinalEuropeanNumberSeparator(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 31;
			A_0 = num;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00014E04 File Offset: 0x00013004
		private static void CalliConvertTimeToUtc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 3;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 366;
			A_0 = num;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00014E68 File Offset: 0x00013068
		public static void ArmSizeChanger(bool Size)
		{
			int num = 158;
			int num2 = 158;
			num2 = 158;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				bool flag13;
				bool flag14;
				bool flag15;
				bool flag16;
				bool flag17;
				bool flag18;
				bool flag19;
				bool flag20;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, ref flag13, ref flag14, ref flag15, ref flag16, ref flag17, ref flag18, ref flag19, ref flag20, Size, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 158;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00014ED4 File Offset: 0x000130D4
		private static void NonSerializedAttributegetAssemblyEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_5.GetComponent<Renderer>().material.color = Color.black;
			A_5.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			A_5.transform.position = A_4.point;
			Object.Destroy(A_5.GetComponent<BoxCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<Collider>());
			Object.Destroy(A_5, Time.deltaTime);
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 7 + 85;
			A_0 = num;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00014FE4 File Offset: 0x000131E4
		private static void SetEnvironmentVariablesetAbbreviatedMonthNames(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_6 = gripDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 274;
			A_0 = num;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00015044 File Offset: 0x00013244
		private static void TimeSpanRawInfoServerWellKnownEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 432;
			A_0 = num;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000150A0 File Offset: 0x000132A0
		private static void AllowThousandsEnumerablePartitionerOptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 10 + 140;
			A_0 = num;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00015140 File Offset: 0x00013340
		private static void BStrWrapperDispatchChannelSink(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			A_1 = 0;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00015158 File Offset: 0x00013358
		private static void PopipopiPOLICYAUDITLOGADMIN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_13 = array;
			A_13[0].color = Mods.FirstColor;
			A_13[0].time = 0f;
			A_13[1].color = Mods.FirstColor;
			A_13[1].time = 0.3f;
			A_13[2].color = Mods.SecondColor;
			A_13[2].time = 0.6f;
			A_13[3].color = Mods.SecondColor;
			A_13[3].time = 1f;
			ColorChanger colorChanger = A_10.AddComponent<ColorChanger>();
			A_14 = colorChanger;
			A_14.colors = new Gradient
			{
				colorKeys = A_13
			};
			A_14.Start();
			A_0 = 88;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000152C8 File Offset: 0x000134C8
		private static void AppDomainUnloadedExceptionConfigure(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool enabled = GorillaTagger.Instance.offlineVRRig.enabled;
			A_4 = enabled;
			int num = ((!A_4) ? 1 : 0) * 1 + 321;
			A_0 = num;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00015330 File Offset: 0x00013530
		private static void PrepareDelegateInternalPartitionEnumerable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_11 = array;
			A_11[0].color = Mods.FirstColor;
			A_11[0].time = 0f;
			A_11[1].color = Mods.FirstColor;
			A_11[1].time = 0.3f;
			A_11[2].color = Mods.SecondColor;
			A_11[2].time = 0.6f;
			A_11[3].color = Mods.SecondColor;
			A_11[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_12 = colorChanger;
			A_12.colors = new Gradient
			{
				colorKeys = A_11
			};
			A_12.Start();
			A_0 = 144;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001549C File Offset: 0x0001369C
		private static void HOSTEDFrameSecurityDescriptorWithResolver(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * 45f;
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 240;
			A_0 = num;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00015530 File Offset: 0x00013730
		private static void TablesClassName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool flag = false;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 20 + 18;
			A_0 = num;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001558C File Offset: 0x0001378C
		private static void GetBooleanArrayRemotingSurrogateSelector(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownL = WristMenu.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 3 + 392;
			A_0 = num;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000155E8 File Offset: 0x000137E8
		private static void getIsAssemblyMarkSequencePoint(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.handTapVolume = 10f;
			A_1 = 0;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00015610 File Offset: 0x00013810
		private static void GBDecodergetPropertyName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.playerText.enabled = false;
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 286;
			A_0 = num;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00015674 File Offset: 0x00013874
		private static void GuidStylesLockMemory(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			Object.Destroy(A_7, Time.deltaTime);
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 52;
			A_0 = num;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000156D0 File Offset: 0x000138D0
		private static void ResolveNamespacegetParameter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 4;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000156F8 File Offset: 0x000138F8
		private static void ProcessArchitecturegetViewAccessControl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.5f";
			bool flag = Mods.DickIsTiny == 6;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001579C File Offset: 0x0001399C
		public static void InvisMonke()
		{
			int num = 299;
			int num2 = 299;
			num2 = 299;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 299;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000157E0 File Offset: 0x000139E0
		private static void UtcTicksHasTrueValue(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance < 1f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 219;
			A_0 = num;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00015848 File Offset: 0x00013A48
		private static void NAMEsetTargetFrameworkName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 115;
			A_0 = num;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00015890 File Offset: 0x00013A90
		private static void AuditFlagsCountedUtfXml(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance > A_4.distance;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 4 + 228;
			A_0 = num;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000158FC File Offset: 0x00013AFC
		private static void GetAllCustDataClientWellKnownEntry(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_4.Add(A_6.buttonText);
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 412;
			A_0 = num;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00015964 File Offset: 0x00013B64
		private static void UnmanagedMemoryStreamWrapperscheduler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00015980 File Offset: 0x00013B80
		private static void FromOACurrencyLocalBuilder(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				Color.white,
				false
			});
			Mods.FlushRemoteProceduralCalls();
			A_1 = 0;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000159E8 File Offset: 0x00013BE8
		private static void getDriveTypePoint(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 12;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 185;
			A_0 = num;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00015A4C File Offset: 0x00013C4C
		private static void IsUppergetObjectAceType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < Mods.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 465;
			A_0 = num;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00015AB4 File Offset: 0x00013CB4
		private static void MdSigCallingConventionsetMemberAccess(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
			A_1 = 0;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00015B28 File Offset: 0x00013D28
		private static void DataAvailablegetWriterSeqNum(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			A_5.enabled = false;
			A_0 = 155;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00015B58 File Offset: 0x00013D58
		private static void DESCKINDVARDESCCloseScope(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local.transform.localScale = Mods.scale;
			Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			Mods.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			Mods.once_left = true;
			Mods.once_left_false = false;
			ColorChanger colorChanger = Mods.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = Mods.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 458;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00015D0C File Offset: 0x00013F0C
		private static void StackBehaviourPushsetRenewalTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00015D24 File Offset: 0x00013F24
		private static void GetSrcItfTypeStable(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 73;
			A_0 = num;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00015D6C File Offset: 0x00013F6C
		private static void GetFieldSigHelperRunImpersonated(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0.07f, 0f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(8f, 0f, 0f);
			GorillaTagger.Instance.offlineVRRig.GetComponent<Collider>().enabled = true;
			A_0 = 312;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00015E0C File Offset: 0x0001400C
		private static void getMinSizeGuid(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_0 = 14;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00015E24 File Offset: 0x00014024
		public static void fpc()
		{
			int num = 398;
			int num2 = 398;
			num2 = 398;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 398;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00015E6C File Offset: 0x0001406C
		private static void IsObjectOutOfAppDomaingetXmlNameSpace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 3 + 320;
			A_0 = num;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00015ED0 File Offset: 0x000140D0
		private static void SetAsNULLCustomErrorsEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 447;
			A_0 = num;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00015F38 File Offset: 0x00014138
		private static void GregorianCalendarHelpersetLatencyMode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_0 = 421;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00015F50 File Offset: 0x00014150
		private static void getTimeOfDayDBNull(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.sizeScale = 1f;
			bool triggerDownR = WristMenu.triggerDownR;
			A_4 = triggerDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 209;
			A_0 = num;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00015FB8 File Offset: 0x000141B8
		private static void getStringMethodName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			bool changingColors = Mods.ChangingColors;
			A_5 = changingColors;
			int num = ((!A_5) ? 1 : 0) * 1 + 135;
			A_0 = num;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00016068 File Offset: 0x00014268
		private static void CriticalHandlePEPlus(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			A_3 = rightControllerPrimaryButton;
			int num = ((!A_3) ? 1 : 0) * 1 + 207;
			A_0 = num;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000160CC File Offset: 0x000142CC
		private static void EncodingTableGetDouble(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			Mods.TurnGay = 0;
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000160FC File Offset: 0x000142FC
		public unsafe static void Save()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 406;
			int num4 = 406;
			num4 = 406;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 406;
						if ((int)array[3] != 0)
						{
							num5 = (int)array[7];
							num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + 32 + num2);
							for (num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + (int)array[5] + 32 + num2) + 24 + num2); num7 != num6; num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num7 + 24 + num2))
							{
								num8 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num7 + 40 + num2);
								if (num8 != -1)
								{
									num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num8 + num2);
									array[5] = num8;
									array[0] = 1;
									num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num8 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[2];
							num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
							ex2 = ex;
							array = (object[])array[4];
							array2 = new object[8];
							array2[3] = 1;
							array2[4] = array;
							array2[2] = ex;
							array2[5] = num5;
							array2[0] = 2;
							array = array2;
							num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
							continue;
						}
						num10 = (int)array[1];
						array = (object[])array[4];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<string> list;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool? flag;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1<System.String>&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Nullable`1<System.Boolean>&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref list, ref enumerator, ref buttonInfo, ref flag, ref flag2, ref flag3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 406;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num15 * 64 + 24 + num2);
						num17 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num15 * 64 + 32 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num7 * 64 + 40 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num14 * 64 + 24 + num2);
						num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num14 * 64 + 32 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num7 * 64 + 40 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num15 * 40 + 16 + num2);
						num17 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num15 * 40 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num7 * 40 + 24 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9B7:
						if (array == null || (int)array[3] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 24 + num2);
								}
								else
								{
									num10 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + 40 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + 24 + num2);
									goto IL_9B7;
								}
							}
							goto IL_B4B;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num15 * 40 + 16 + num2);
								num10 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num15 * 40 + 8 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num5 * 40 + 24 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num7 + 24 + num2);
								}
								else
								{
									num5 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + 40 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + 24 + num2);
									goto IL_9B7;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[4];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[4] = array;
					array2[1] = num11;
					array2[5] = num5;
					array2[0] = 1;
					array = array2;
					num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B4B:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[4] = array;
					array2[1] = num11;
					array2[5] = num10;
					array2[0] = 1;
					array = array2;
					num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + num2);
				}
				num4 = 406;
				return;
				IL_1BE:
				if (num6 != -1)
				{
					goto IL_1C9;
				}
				goto IL_3E7;
				IL_1C9:
				num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 40 + num2);
				if (2 == num7)
				{
					goto IL_1E8;
				}
				if (1 == num7)
				{
					goto IL_36E;
				}
				goto IL_3E7;
				IL_1E8:
				num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 48 + num2);
				if (num9 == -1)
				{
					goto IL_236;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_21C;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_21C:
				if (type.IsInstanceOfType(array2[2]))
				{
					goto IL_236;
				}
				num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 56 + num2);
				goto IL_1BE;
				IL_236:
				num5 = num6;
				num8 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + 32 + num2) + 24 + num2);
				num13 = (int)array2[6];
				IL_25A:
				if (num13 != num8)
				{
					goto IL_2D3;
				}
				int num22 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
				ex2 = array2[2];
				array = (object[])array[4];
				object[] array5 = new object[8];
				array5[3] = 1;
				array5[4] = array;
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[5] = num5;
				array5[0] = 2;
				array = array5;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
				goto IL_23;
				IL_2D3:
				num18 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num13 + 40 + num2);
				if (num18 == -1)
				{
					goto IL_35C;
				}
				num22 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + num2);
				array = (object[])array[4];
				array5 = new object[8];
				array5[3] = 1;
				array5[4] = array;
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[5] = num18;
				array5[7] = num5;
				array5[0] = 1;
				array = array5;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num18 + num2);
				goto IL_23;
				IL_35C:
				num13 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num13 + 24 + num2);
				goto IL_25A;
				IL_36E:
				num22 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 24 + num2);
				ex2 = array2[2];
				array = (object[])array[4];
				array5 = new object[8];
				array5[3] = 1;
				array5[4] = array;
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[5] = num6;
				array5[0] = 0;
				array = array5;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num6 + 24 + num2);
				goto IL_23;
				IL_3E7:
				array = (object[])array[4];
				Exception ex3 = array2[2];
				int num23 = (int)array2[6];
				IL_406:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_414:
				num14 = (num21 + num10) / 2;
				num15 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num14 * 64 + 24 + num2);
				num16 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num14 * 64 + 32 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_45A;
				}
				if (num15 > num22)
				{
					goto IL_462;
				}
				num8 = num14;
				num5 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 144 + num8 * 64 + 40 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_48A;
				IL_45A:
				num21 = num14 + 1;
				goto IL_414;
				IL_462:
				num10 = num14 - 1;
				goto IL_414;
				IL_48A:
				if (array != null)
				{
					goto IL_495;
				}
				goto IL_61C;
				IL_495:
				if ((int)array[3] != 0)
				{
					goto IL_551;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4B9;
				}
				int num25 = -1;
				goto IL_538;
				IL_4B9:
				num17 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num9 + num2);
				num16 = 0;
				num15 = 2;
				IL_4C9:
				num14 = (num16 + num15) / 2;
				num10 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num14 * 40 + 16 + num2);
				num21 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num14 * 40 + 8 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_50E;
				}
				if (num10 > num17)
				{
					goto IL_516;
				}
				num5 = num14;
				num8 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num5 * 40 + 24 + num2);
				num25 = num8;
				goto IL_538;
				IL_50E:
				num16 = num14 + 1;
				goto IL_4C9;
				IL_516:
				num15 = num14 - 1;
				goto IL_4C9;
				IL_538:
				if (num24 != num25)
				{
					goto IL_540;
				}
				goto IL_61C;
				IL_540:
				array = (object[])array[4];
				goto IL_48A;
				IL_551:
				num18 = (int)array[0];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_572;
				}
				if (num18 != 0)
				{
					goto IL_571;
				}
				array2 = array;
				num6 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + (int)array2[5] + 56 + num2);
				goto IL_1BE;
				IL_571:
				IL_572:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_587;
				}
				int num27 = -1;
				goto IL_606;
				IL_587:
				num22 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num9 + num2);
				num21 = 0;
				num10 = 2;
				IL_597:
				num14 = (num21 + num10) / 2;
				num15 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num14 * 40 + 16 + num2);
				num16 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num14 * 40 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5DC;
				}
				if (num15 > num22)
				{
					goto IL_5E4;
				}
				num8 = num14;
				num5 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + 336 + num8 * 40 + 24 + num2);
				num27 = num5;
				goto IL_606;
				IL_5DC:
				num21 = num14 + 1;
				goto IL_597;
				IL_5E4:
				num10 = num14 - 1;
				goto IL_597;
				IL_606:
				if (num26 != num27)
				{
					goto IL_60B;
				}
				goto IL_61C;
				IL_60B:
				array = (object[])array[4];
				goto IL_48A;
				IL_61C:
				if (-1 != num9)
				{
					goto IL_628;
				}
				int num28 = 1;
				throw ex3;
				IL_628:
				num7 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num9 + 32 + num2);
				num10 = num7;
				IL_639:
				if (num10 != -1)
				{
					goto IL_650;
				}
				num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num9 + 24 + num2);
				goto IL_48A;
				IL_650:
				num15 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + 40 + num2);
				if (2 == num15)
				{
					goto IL_67B;
				}
				if (1 == num15)
				{
					goto IL_7DD;
				}
				num9 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num9 + 24 + num2);
				goto IL_48A;
				IL_67B:
				num14 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + 48 + num2);
				if (num14 == -1)
				{
					goto IL_6CA;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6AF;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6AF:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6CA;
				}
				num10 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + 56 + num2);
				goto IL_639;
				IL_6CA:
				num5 = num10;
				num8 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + 32 + num2) + 24 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6F3:
				if (num17 != num8)
				{
					goto IL_756;
				}
				num21 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[4] = array;
				array2[2] = ex3;
				array2[6] = num13;
				array2[5] = num5;
				array2[0] = 2;
				array = array2;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num5 + num2);
				goto IL_23;
				IL_756:
				num16 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num17 + 40 + num2);
				if (num16 == -1)
				{
					goto IL_7CB;
				}
				num21 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num16 + num2);
				array2 = new object[8];
				array2[3] = 1;
				array2[4] = array;
				array2[2] = ex3;
				array2[6] = num13;
				array2[5] = num16;
				array2[7] = num5;
				array2[0] = 1;
				array = array2;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num16 + num2);
				goto IL_23;
				IL_7CB:
				num17 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num17 + 24 + num2);
				goto IL_6F3;
				IL_7DD:
				num21 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + 24 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[4] = array;
				array2[2] = ex3;
				array2[6] = num13;
				array2[5] = num10;
				array2[0] = 0;
				array = array2;
				num3 = *(ref LdlocaSGetEnumeratorDelegate.GetIDispatchForObjectInContextgetIsMulticast + num10 + 24 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_406;
				}
				throw ex4;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00016D08 File Offset: 0x00014F08
		private static void getIsReadOnlyEVENTACTIVITYCTRLGETID(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 7;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 175;
			A_0 = num;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00016D6C File Offset: 0x00014F6C
		public static void Settings()
		{
			int num = 2;
			int num2 = 2;
			num2 = 2;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 2;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00016DA0 File Offset: 0x00014FA0
		private static void getAssemblyIsPrivateSecureStringToCoTaskMemUnicode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_1 = 5;
			A_2 = 42;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00016DC4 File Offset: 0x00014FC4
		private static void AllowParenthesisAptca(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.funn.SetActive(true);
			Mods.funn = null;
			A_1 = 0;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00016DF4 File Offset: 0x00014FF4
		private static void getSubjectGetElement(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 13 + 81;
			A_0 = num;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00016E50 File Offset: 0x00015050
		private static void BigEndianUnicodeCopyFromIndirect(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			WristMenu.settingsbuttons[1].enabled = new bool?(false);
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			List<string> list = new List<string>();
			A_4 = list;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.settingsbuttons.GetEnumerator();
			A_5 = enumerator;
			A_0 = 407;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00016ECC File Offset: 0x000150CC
		private static void setHashNameParent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 3 + 308;
			A_0 = num;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00016F30 File Offset: 0x00015130
		private static void setMembershipConditionXsdString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 6 + 333;
			A_0 = num;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00016FB0 File Offset: 0x000151B0
		private static void PublicationOnlyLargestWindowWidth(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 10 + 140;
			A_0 = num;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00017034 File Offset: 0x00015234
		private static void IIDENTITYAUTHORITYDEFINITIONIDENTITYTOTEXTFLAGCANONICALFullName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 457;
			A_0 = num;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00017090 File Offset: 0x00015290
		private static void getTotalMinutesBlack(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.5f";
			bool flag = Mods.DickIsTiny == 12;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 185;
			A_0 = num;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00017134 File Offset: 0x00015334
		private static void IConnectionPointContainergetCommandLineFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001714C File Offset: 0x0001534C
		private static void RSACryptoServiceProvidersetControlDomainPolicy(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.inSettings = false;
			Mods.flySpeed = 5f;
			Mods.TurnGay = 0;
			Mods.Jumpthing = 0f;
			Mods.Fix = false;
			Mods.IsGay = true;
			Mods.DickIsTiny = 0;
			Mods.MainT = null;
			Mods.PCUser = false;
			Mods.sizeScale = 1f;
			Mods.FirstColor = Color.black;
			Mods.SecondColor = Color.red;
			Mods.ChangingColors = true;
			Mods.Deli = 0f;
			Mods.invisplat = false;
			Mods.stickyplatforms = false;
			Mods.scale = new Vector3(0.0125f, 0.28f, 0.3825f);
			Mods.jump_left_network = new GameObject[9999];
			Mods.jump_right_network = new GameObject[9999];
			Mods.jump_left_local = null;
			Mods.jump_right_local = null;
			Mods.colorKeysPlatformMonke = new GradientColorKey[4];
			A_1 = 0;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00017254 File Offset: 0x00015454
		private static void getIgnorePortablePDBsInStackTracesgetThreadState(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 274;
			A_0 = num;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000172B0 File Offset: 0x000154B0
		private static void SetTypedReferencevt(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_9.enabled = new bool?(true);
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 422;
			A_0 = num;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00017310 File Offset: 0x00015510
		private static void CurrentStateCompareExchange(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00017328 File Offset: 0x00015528
		private static void getTwoLetterISOLanguageNameFieldOnTypeBuilderInstantiation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			RigShit.GetPlayerFromRig(GorillaTagger.Instance.offlineVRRig);
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0.07f, 0f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(8f, 0f, 0f);
			GorillaTagger.Instance.offlineVRRig.GetComponent<Collider>().enabled = true;
			A_0 = 312;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000173DC File Offset: 0x000155DC
		private static void ArgumentsGetOneYearLocalFromUtc(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_1 = 3;
			A_2 = 75;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00017400 File Offset: 0x00015600
		private static void ArgMapperGetTypeForITypeInfo(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.gravity = new Vector3(0f, -9.81f, 0f);
			A_0 = 226;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00017434 File Offset: 0x00015634
		private static void TrimFreeSizeOKIsAppEarlierThanSilverlight(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00017464 File Offset: 0x00015664
		private static void ConfiguredTaskAwaiterVARDISPATCH(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.colorKeysPlatformMonke[0].color = Color.black;
			Mods.colorKeysPlatformMonke[0].time = 1f;
			Mods.colorKeysPlatformMonke[1].color = Color.black;
			Mods.colorKeysPlatformMonke[1].time = 0.5f;
			Mods.colorKeysPlatformMonke[2].color = Color.red;
			Mods.colorKeysPlatformMonke[2].time = 1f;
			Mods.colorKeysPlatformMonke[3].color = Color.red;
			Mods.colorKeysPlatformMonke[3].time = 0.5f;
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = WristMenu.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 429;
			A_0 = num;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000175B8 File Offset: 0x000157B8
		private static void getSourceNamegetCurrencyGroupSizes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			string name = A_7.gameObject.name;
			A_9 = name;
			Transform transform = A_7.Find("GorillaScoreBoard/LineParent");
			A_7 = transform;
			int num = 0;
			A_10 = num;
			A_0 = 36;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00017630 File Offset: 0x00015830
		public static void FixHead()
		{
			int num = 215;
			int num2 = 215;
			num2 = 215;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 215;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00017674 File Offset: 0x00015874
		private static void EscapeThreadTransferSendObj(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 294;
			A_0 = num;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000176D0 File Offset: 0x000158D0
		private static void ModeInvalidEscapeContinuationResultTaskFromResultTask(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000176E8 File Offset: 0x000158E8
		private static void CModOptIsMemberRef(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_8.GetComponent<Renderer>().material.color = Color.black;
			Object.Destroy(A_7, Time.deltaTime);
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 52;
			A_0 = num;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00017764 File Offset: 0x00015964
		public static void SpazMonkey()
		{
			int num = 129;
			int num2 = 129;
			num2 = 129;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 129;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000177A8 File Offset: 0x000159A8
		private static void ReadBlockAsyncCheckedForAsync(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			Physics.Raycast(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.forward, ref A_4);
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_5 = gameObject;
			bool changingColors = Mods.ChangingColors;
			A_6 = changingColors;
			int num = ((!A_6) ? 1 : 0) * 1 + 82;
			A_0 = num;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00017848 File Offset: 0x00015A48
		public static void GrabBat()
		{
			int num = 257;
			int num2 = 257;
			num2 = 257;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 257;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001788C File Offset: 0x00015A8C
		private static void DYMgetLastWriteTime(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 3;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000178B4 File Offset: 0x00015AB4
		private static void RNGCryptoServiceProviderPermissionSetAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_9 = triggerDownL;
			int num = ((!A_9) ? 1 : 0) * 4 + 141;
			A_0 = num;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00017910 File Offset: 0x00015B10
		public static void Fly()
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 3;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00017944 File Offset: 0x00015B44
		private static void CastGO(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 10 + 343;
			A_0 = num;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000179A8 File Offset: 0x00015BA8
		private static void CCMAXDidNotExist(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 96;
			A_0 = num;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00017A04 File Offset: 0x00015C04
		private static void ReadToEndAsyncInternaldLSATRUSTINFORMATION(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 277;
			A_0 = num;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00017A4C File Offset: 0x00015C4C
		private static void getDirectorySectionSetCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			WristMenu.settingsbuttons[6].enabled = new bool?(false);
			WristMenu.DestroyMenu();
			bool flag = !A_23;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 159;
			A_0 = num;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00017AD4 File Offset: 0x00015CD4
		private static void StoppedRethrow(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = A_10 + 1;
			A_10 = num;
			bool flag = A_10 < A_7.childCount;
			A_23 = flag;
			int num2 = (A_23 ? 1 : 0) * -18 + 37;
			A_0 = num2;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00017B68 File Offset: 0x00015D68
		private static void SharedStateFReplaceable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 6 + 133;
			A_0 = num;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00017BC4 File Offset: 0x00015DC4
		private static void viewGlobalizationExtensions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			RigShit.GetPlayerFromRig(GorillaTagger.Instance.offlineVRRig);
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0f, 0.07f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 0f, 8f);
			GorillaTagger.Instance.offlineVRRig.GetComponent<Collider>().enabled = true;
			A_0 = 318;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00017C78 File Offset: 0x00015E78
		private static void setMonitoringIsEnabledPolicy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 14;
			A_18 = flag;
			int num = ((!A_18) ? 1 : 0) * 1 + 189;
			A_0 = num;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00017CDC File Offset: 0x00015EDC
		private static void RuntimeWrappedExceptionShadowCopyFilesValue(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 286;
			A_0 = num;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00017D24 File Offset: 0x00015F24
		private static void ControlThreadmname(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0f, 0.05f);
			GorillaTagger.Instance.myVRRig.transform.position = GorillaTagger.Instance.offlineVRRig.transform.position;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.forward;
			A_0 = 98;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00017DCC File Offset: 0x00015FCC
		private static void getMemberBasic(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_10 = array;
			A_10[0].color = Mods.FirstColor;
			A_10[0].time = 0f;
			A_10[1].color = Mods.FirstColor;
			A_10[1].time = 0.3f;
			A_10[2].color = Mods.SecondColor;
			A_10[2].time = 0.6f;
			A_10[3].color = Mods.SecondColor;
			A_10[3].time = 1f;
			ColorChanger colorChanger = A_7.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			A_11.colors = new Gradient
			{
				colorKeys = A_10
			};
			A_11.Start();
			A_0 = 49;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00017F3C File Offset: 0x0001613C
		private static void CreateComInstanceFromcImplTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_10.GetComponent<Renderer>().material.color = Color.black;
			bool changingColors = Mods.ChangingColors;
			A_15 = changingColors;
			int num = ((!A_15) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00017FB8 File Offset: 0x000161B8
		private static void NormalizationFormSetOnInvokeMres(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool enabled = GorillaTagger.Instance.offlineVRRig.enabled;
			A_4 = enabled;
			int num = ((!A_4) ? 1 : 0) * 1 + 315;
			A_0 = num;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00018020 File Offset: 0x00016220
		private static void removeEventSourceCreatedgetEncoderFallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 6;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 173;
			A_0 = num;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00018084 File Offset: 0x00016284
		private static void SeedgetMachineKeyStore(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.transform.position = A_4.point;
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 351;
			A_0 = num;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00018118 File Offset: 0x00016318
		private static void AddValuePayload(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			int num = ((!(A_5 != GorillaTagger.Instance.offlineVRRig)) ? 1 : 0) * 1 + 272;
			A_0 = num;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00018188 File Offset: 0x00016388
		private static void MAXPARAMSgetIsAppEarlierThanWindowsPhoneMango(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.1f";
			bool flag = Mods.DickIsTiny == 2;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 165;
			A_0 = num;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001822C File Offset: 0x0001642C
		private static void LiveActivitiesWindowsRuntimeMarshal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.1f";
			bool flag = Mods.DickIsTiny == 8;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 177;
			A_0 = num;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000182D0 File Offset: 0x000164D0
		private static void PercentDecimalSeparatorASCII(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 464;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00018300 File Offset: 0x00016500
		private static void ITypeInfoCOREISOSTORE(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			Traverse.Create(ScienceExperimentManager.instance).Field("inGamePlayerStates").SetValue(A_3);
			A_1 = 0;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001833C File Offset: 0x0001653C
		private static void CustomAttributeNamedParameterSetContextNameObject(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.tapCoolDown = 0.33f;
			A_1 = 0;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00018364 File Offset: 0x00016564
		private static void DangerousGetRawSecurityContextMulOvf(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool flag = A_6 < A_5.childCount;
			A_24 = flag;
			int num = (A_24 ? 1 : 0) * -25 + 40;
			A_0 = num;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000183D4 File Offset: 0x000165D4
		private static void GetDynamicPartitionsaddProcessExit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 6;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 372;
			A_0 = num;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00018438 File Offset: 0x00016638
		private static void INVOKEPROPERTYPUTAddOvf(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 31;
			A_0 = num;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00018480 File Offset: 0x00016680
		private static void getMemberTypeByteTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
			{
				203,
				false,
				999999f
			});
			Mods.FlushRemoteProceduralCalls();
			A_1 = 0;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000184F8 File Offset: 0x000166F8
		private static void MachineKeysetCreatePermissionSet(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
			A_5.mainSkin.material.color = A_5.playerColor;
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 115;
			A_0 = num;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001858C File Offset: 0x0001678C
		private static void IsSecurityTransparentViewAcl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 1;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 163;
			A_0 = num;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000185F0 File Offset: 0x000167F0
		public static void DayTime()
		{
			int num = 264;
			int num2 = 264;
			num2 = 264;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 264;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00018634 File Offset: 0x00016834
		private static void getMinutesDesktopDirectory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 267;
			A_0 = num;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00018690 File Offset: 0x00016890
		private static void cancellationTokenSetLastError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x000186A8 File Offset: 0x000168A8
		private static void getIsRelativeFileUrlDangerousGetRawSecurityContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 10 + 140;
			A_0 = num;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001870C File Offset: 0x0001690C
		private static void IsNegativeInfinitygetIsWriterLockHeld(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 52;
			A_0 = num;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00018754 File Offset: 0x00016954
		private static void GetDeclaredMethodsdCreatePageFile(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_1 = 5;
			A_2 = 33;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00018778 File Offset: 0x00016978
		private static void GetConstructorTokenNonSerializedAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 4;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000187A0 File Offset: 0x000169A0
		private static void NativeNameCreateActContextParametersSourceDefinitionAppid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 300;
			A_0 = num;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000187FC File Offset: 0x000169FC
		private static void AssemblyFormatDeclaredMembers(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			GameObject gameObject = new GameObject("Line");
			A_7 = gameObject;
			LineRenderer lineRenderer = A_7.AddComponent<LineRenderer>();
			A_8 = lineRenderer;
			A_8.startWidth = 0.025f;
			A_8.endWidth = 0.025f;
			A_8.positionCount = 2;
			A_8.useWorldSpace = true;
			A_8.SetPosition(0, A_5.transform.position + new Vector3(0f, 9999f, 0f));
			A_8.SetPosition(1, A_5.transform.position - new Vector3(0f, 9999f, 0f));
			A_8.material.shader = Shader.Find("GUI/Text Shader");
			bool changingColors = Mods.ChangingColors;
			A_9 = changingColors;
			int num = ((!A_9) ? 1 : 0) * 1 + 47;
			A_0 = num;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00018980 File Offset: 0x00016B80
		private static void getCommandLineParametersGetParameters(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 457;
			A_0 = num;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000189E8 File Offset: 0x00016BE8
		private static void grfLocksSupportedgetSetActorAsReferenceWhenCopyingClaimsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Faster";
			Mods.flySpeed = 40f;
			bool flag = Mods.TurnGay == 11;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 1 + 384;
			A_0 = num;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00018A70 File Offset: 0x00016C70
		private static void FreeBufferNullContextAttributeEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 447;
			A_0 = num;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00018ACC File Offset: 0x00016CCC
		private static void MoveIsolatedStorageFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			Mods.TurnGay = 0;
			bool flag = !A_18;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 358;
			A_0 = num;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00018B3C File Offset: 0x00016D3C
		public static void HideName()
		{
			int num = 131;
			int num2 = 131;
			num2 = 131;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 131;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00018B80 File Offset: 0x00016D80
		private static void smallResulteFixedBufferCurrentUser(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 3;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00018BA8 File Offset: 0x00016DA8
		private static void getWorkingSetGetSurrogateForCyclicalReference(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				GorillaTagger.Instance.rightHandTransform.position,
				GorillaTagger.Instance.rightHandTransform.rotation,
				4f,
				100f,
				true,
				false
			});
			Mods.FlushRemoteProceduralCalls();
			Mods.Deli = Time.time + 0.1f;
			bool gripDownL = WristMenu.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 3 + 392;
			A_0 = num;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00018CBC File Offset: 0x00016EBC
		private static void PausingADAsyncWorkItem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_6 = array;
			A_6[0].color = Mods.FirstColor;
			A_6[0].time = 0f;
			A_6[1].color = Mods.FirstColor;
			A_6[1].time = 0.3f;
			A_6[2].color = Mods.SecondColor;
			A_6[2].time = 0.6f;
			A_6[3].color = Mods.SecondColor;
			A_6[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_7 = colorChanger;
			A_7.colors = new Gradient
			{
				colorKeys = A_6
			};
			A_7.Start();
			A_0 = 331;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00018E28 File Offset: 0x00017028
		private static void PlusGetType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 432;
			A_0 = num;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00018E90 File Offset: 0x00017090
		private static void HasIdentitiesDefinitionIdentity(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 125;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00018EA8 File Offset: 0x000170A8
		private static void PaddingModeEnglishName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool changingColors = Mods.ChangingColors;
			A_10 = changingColors;
			int num = ((!A_10) ? 1 : 0) * 1 + 142;
			A_0 = num;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00018F04 File Offset: 0x00017104
		private static void HashElementTransformProxy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_right ? 1 : 0) * 1 + 430;
			A_0 = num;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00018F48 File Offset: 0x00017148
		private static void SeparatorTokenMaskSetShadowCopyPath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 3 + 314;
			A_0 = num;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00018FAC File Offset: 0x000171AC
		private static void EndGetResponseIMPFASTFLOW(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00018FC4 File Offset: 0x000171C4
		public unsafe static void Load()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 415;
			int num4 = 415;
			num4 = 415;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num22;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 2)
					{
						num4 = 415;
						if ((int)array[5] != 1)
						{
							num5 = (int)array[0];
							num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 56 + num2);
							for (num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + (int)array[1] + 56 + num2) + 40 + num2); num7 != num6; num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num7 + 40 + num2))
							{
								num8 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num7 + 8 + num2);
								if (num8 != -1)
								{
									num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num8 + 64 + num2);
									array[1] = num8;
									array[6] = 1;
									num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num8 + 64 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[2];
							num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
							ex2 = ex;
							array = (object[])array[4];
							array2 = new object[8];
							array2[5] = 0;
							array2[4] = array;
							array2[2] = ex;
							array2[1] = num5;
							array2[6] = 0;
							array = array2;
							num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[4];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							string[] array3;
							string[] array4;
							int num13;
							string text;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.String[]&,System.String[]&,System.Int32&,System.String&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref array3, ref array4, ref num13, ref text, ref enumerator, ref buttonInfo, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 415;
						num8 = num12;
						num11 = num8;
					}
					num14 = num3;
					num6 = num14;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num16 * 48 + 24 + num2);
						num18 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num16 * 48 + 16 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num7 * 48 + num2);
					num19 = num9;
					num18 = num11;
					num17 = 0;
					num16 = 2;
					for (;;)
					{
						num15 = (num17 + num16) / 2;
						num10 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num15 * 48 + 24 + num2);
						num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num15 * 48 + 16 + num2);
						if (num18 < num10 + num6)
						{
							if (num10 <= num18)
							{
								break;
							}
							num16 = num15 - 1;
						}
						else
						{
							num17 = num15 + 1;
						}
					}
					num7 = num15;
					num8 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num7 * 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num16 * 72 + 40 + num2);
						num18 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num16 * 72 + 32 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num5 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num7 * 72 + 8 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D5:
						if (array == null || (int)array[5] == 1)
						{
							num6 = num9;
							while (num6 != num19)
							{
								if (num6 != -1)
								{
									num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 40 + num2);
								}
								else
								{
									num10 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 8 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num19 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 40 + num2);
									goto IL_9D5;
								}
							}
							goto IL_B71;
						}
						int num20 = (int)array[1];
						int num21;
						if (num19 == -1)
						{
							num21 = -1;
						}
						else
						{
							num22 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 56 + num2);
							num18 = 0;
							num17 = 2;
							for (;;)
							{
								num16 = (num18 + num17) / 2;
								num15 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num16 * 72 + 40 + num2);
								num10 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num16 * 72 + 32 + num2);
								if (num22 < num15 + num10)
								{
									if (num15 <= num22)
									{
										break;
									}
									num17 = num16 - 1;
								}
								else
								{
									num18 = num16 + 1;
								}
							}
							num5 = num16;
							num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num5 * 72 + 8 + num2);
							num21 = num7;
						}
						if (num20 == num21)
						{
							num7 = num9;
							while (num7 != num19)
							{
								if (num7 != -1)
								{
									num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num7 + 40 + num2);
								}
								else
								{
									num5 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 8 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num19 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 40 + num2);
									goto IL_9D5;
								}
							}
							break;
						}
						if ((int)array[1] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[4];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
					array2 = new object[8];
					array2[5] = 1;
					array2[4] = array;
					array2[7] = num11;
					array2[1] = num5;
					array2[6] = 1;
					array = array2;
					num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B71:
					num3 = num11;
					continue;
					Block_58:
					num15 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 64 + num2);
					array2 = new object[8];
					array2[5] = 1;
					array2[4] = array;
					array2[7] = num11;
					array2[1] = num10;
					array2[6] = 1;
					array = array2;
					num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 64 + num2);
				}
				num4 = 415;
				return;
				IL_1CB:
				if (num6 != -1)
				{
					goto IL_1D6;
				}
				goto IL_3FE;
				IL_1D6:
				num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 40 + num2);
				if (3 == num7)
				{
					goto IL_1F5;
				}
				if (2 == num7)
				{
					goto IL_385;
				}
				goto IL_3FE;
				IL_1F5:
				num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 8 + num2);
				if (num9 == -1)
				{
					goto IL_242;
				}
				Type[] array5;
				Type type;
				if ((type = array5[num9]) != null)
				{
					goto IL_228;
				}
				RuntimeTypeHandle[] array6;
				array5[num9] = Type.GetTypeFromHandle(array6[num9]);
				type = array5[num9];
				IL_228:
				if (type.IsInstanceOfType(array2[2]))
				{
					goto IL_242;
				}
				num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 48 + num2);
				goto IL_1CB;
				IL_242:
				num5 = num6;
				num8 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 56 + num2) + 40 + num2);
				num14 = (int)array2[3];
				IL_266:
				if (num14 != num8)
				{
					goto IL_2E5;
				}
				int num23 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
				ex2 = array2[2];
				array = (object[])array[4];
				object[] array7 = new object[8];
				array7[5] = 0;
				array7[4] = array;
				array7[2] = array2[2];
				array7[3] = (int)array2[3];
				array7[1] = num5;
				array7[6] = 0;
				array = array7;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
				goto IL_23;
				IL_2E5:
				num19 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num14 + 8 + num2);
				if (num19 == -1)
				{
					goto IL_373;
				}
				num23 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 64 + num2);
				array = (object[])array[4];
				array7 = new object[8];
				array7[5] = 0;
				array7[4] = array;
				array7[2] = array2[2];
				array7[3] = (int)array2[3];
				array7[1] = num19;
				array7[0] = num5;
				array7[6] = 1;
				array = array7;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num19 + 64 + num2);
				goto IL_23;
				IL_373:
				num14 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num14 + 40 + num2);
				goto IL_266;
				IL_385:
				num23 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 24 + num2);
				ex2 = array2[2];
				array = (object[])array[4];
				array7 = new object[8];
				array7[5] = 0;
				array7[4] = array;
				array7[2] = array2[2];
				array7[3] = (int)array2[3];
				array7[1] = num6;
				array7[6] = 2;
				array = array7;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num6 + 24 + num2);
				goto IL_23;
				IL_3FE:
				array = (object[])array[4];
				Exception ex3 = array2[2];
				int num24 = (int)array2[3];
				IL_41D:
				num6 = num3;
				num23 = num6;
				num22 = 0;
				num10 = 2;
				IL_42B:
				num15 = (num22 + num10) / 2;
				num16 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num15 * 48 + 24 + num2);
				num17 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num15 * 48 + 16 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_471;
				}
				if (num16 > num23)
				{
					goto IL_479;
				}
				num8 = num15;
				num5 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 160 + num8 * 48 + num2);
				num9 = num5;
				num14 = num9;
				goto IL_49E;
				IL_471:
				num22 = num15 + 1;
				goto IL_42B;
				IL_479:
				num10 = num15 - 1;
				goto IL_42B;
				IL_49E:
				if (array != null)
				{
					goto IL_4A9;
				}
				goto IL_636;
				IL_4A9:
				if ((int)array[5] != 1)
				{
					goto IL_568;
				}
				int num25 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_4CD;
				}
				int num26 = -1;
				goto IL_54F;
				IL_4CD:
				num18 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num9 + 56 + num2);
				num17 = 0;
				num16 = 2;
				IL_4E0:
				num15 = (num17 + num16) / 2;
				num10 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num15 * 72 + 40 + num2);
				num22 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num15 * 72 + 32 + num2);
				if (num18 >= num10 + num22)
				{
					goto IL_526;
				}
				if (num10 > num18)
				{
					goto IL_52E;
				}
				num5 = num15;
				num8 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num5 * 72 + 8 + num2);
				num26 = num8;
				goto IL_54F;
				IL_526:
				num17 = num15 + 1;
				goto IL_4E0;
				IL_52E:
				num16 = num15 - 1;
				goto IL_4E0;
				IL_54F:
				if (num25 != num26)
				{
					goto IL_557;
				}
				goto IL_636;
				IL_557:
				array = (object[])array[4];
				goto IL_49E;
				IL_568:
				num19 = (int)array[6];
				if (num19 == 0 || num19 == 1)
				{
					goto IL_589;
				}
				if (num19 != 2)
				{
					goto IL_588;
				}
				array2 = array;
				num6 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + (int)array2[1] + 48 + num2);
				goto IL_1CB;
				IL_588:
				IL_589:
				int num27 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_59E;
				}
				int num28 = -1;
				goto IL_620;
				IL_59E:
				num23 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num9 + 56 + num2);
				num22 = 0;
				num10 = 2;
				IL_5B1:
				num15 = (num22 + num10) / 2;
				num16 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num15 * 72 + 40 + num2);
				num17 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num15 * 72 + 32 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_5F7;
				}
				if (num16 > num23)
				{
					goto IL_5FF;
				}
				num8 = num15;
				num5 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + 304 + num8 * 72 + 8 + num2);
				num28 = num5;
				goto IL_620;
				IL_5F7:
				num22 = num15 + 1;
				goto IL_5B1;
				IL_5FF:
				num10 = num15 - 1;
				goto IL_5B1;
				IL_620:
				if (num27 != num28)
				{
					goto IL_625;
				}
				goto IL_636;
				IL_625:
				array = (object[])array[4];
				goto IL_49E;
				IL_636:
				if (-1 != num9)
				{
					goto IL_642;
				}
				int num29 = 1;
				throw ex3;
				IL_642:
				num7 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num9 + 32 + num2);
				num10 = num7;
				IL_653:
				if (num10 != -1)
				{
					goto IL_66A;
				}
				num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num9 + 40 + num2);
				goto IL_49E;
				IL_66A:
				num16 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 40 + num2);
				if (3 == num16)
				{
					goto IL_695;
				}
				if (2 == num16)
				{
					goto IL_801;
				}
				num9 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num9 + 40 + num2);
				goto IL_49E;
				IL_695:
				num15 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 8 + num2);
				if (num15 == -1)
				{
					goto IL_6E3;
				}
				Type type2;
				if ((type2 = array5[num15]) != null)
				{
					goto IL_6C8;
				}
				array5[num15] = Type.GetTypeFromHandle(array6[num15]);
				type2 = array5[num15];
				IL_6C8:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E3;
				}
				num10 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 48 + num2);
				goto IL_653;
				IL_6E3:
				num5 = num10;
				num8 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 56 + num2) + 40 + num2);
				num18 = (num14 - num24) * ((num24 == -1) ? 1 : 0) + num24;
				IL_70C:
				if (num18 != num8)
				{
					goto IL_775;
				}
				num22 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[5] = 0;
				array2[4] = array;
				array2[2] = ex3;
				array2[3] = num14;
				array2[1] = num5;
				array2[6] = 0;
				array = array2;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num5 + 64 + num2);
				goto IL_23;
				IL_775:
				num17 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num18 + 8 + num2);
				if (num17 == -1)
				{
					goto IL_7EF;
				}
				num22 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num17 + 64 + num2);
				array2 = new object[8];
				array2[5] = 0;
				array2[4] = array;
				array2[2] = ex3;
				array2[3] = num14;
				array2[1] = num17;
				array2[0] = num5;
				array2[6] = 1;
				array = array2;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num17 + 64 + num2);
				goto IL_23;
				IL_7EF:
				num18 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num18 + 40 + num2);
				goto IL_70C;
				IL_801:
				num22 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 24 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[5] = 0;
				array2[4] = array;
				array2[2] = ex3;
				array2[3] = num14;
				array2[1] = num10;
				array2[6] = 2;
				array = array2;
				num3 = *(ref IsolatedStorageFilePermissionRole.ResultgetArgs + num10 + 24 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num29;
				if (num29 != 1)
				{
					Exception ex3 = ex4;
					int num24 = -1;
					goto IL_41D;
				}
				throw ex4;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00019BFC File Offset: 0x00017DFC
		private static void ImportantsetCodeBase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.Fix = false;
			A_0 = 204;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00019C20 File Offset: 0x00017E20
		private static void GetExceptionPointerssetEventChannelType(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.tapCoolDown = 0f;
			A_1 = 0;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00019C48 File Offset: 0x00017E48
		private static void getBytesUnknownsetCheckExecutionRights(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			A_1 = 0;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00019C60 File Offset: 0x00017E60
		private static void LdargaAsInt(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 58;
			A_0 = num;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00019CEC File Offset: 0x00017EEC
		private static void AccessRuleFactoryBlockLongPaths(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 9;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 179;
			A_0 = num;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00019D50 File Offset: 0x00017F50
		private static void getEntryAssemblygetLastWriteTimeUtc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00019D80 File Offset: 0x00017F80
		private static void getOpCodeTypePropertyAnalysis(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Player.Instance.scale = Mods.sizeScale;
			A_1 = 0;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00019DA8 File Offset: 0x00017FA8
		private static void BeginThreadAffinityAwayFromZero(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 3;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 167;
			A_0 = num;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00019E0C File Offset: 0x0001800C
		private static void getInvalidCultureNameTypeEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.1f";
			bool flag = Mods.DickIsTiny == 14;
			A_18 = flag;
			int num = ((!A_18) ? 1 : 0) * 1 + 189;
			A_0 = num;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00019EB0 File Offset: 0x000180B0
		private static void IdentityReferenceInstantiationArgs(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_1 = 5;
			A_2 = 42;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00019ED8 File Offset: 0x000180D8
		private static void VTDATEgetDays(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool flag = Mods.pointer == null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 4 + 134;
			A_0 = num;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00019F3C File Offset: 0x0001813C
		private static void ArgumentAddingDuplicatePOLICYSERVERADMIN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 461;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00019F6C File Offset: 0x0001816C
		private static void VersionResultParentField(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 401;
			A_0 = num;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00019FD4 File Offset: 0x000181D4
		private static void MyMusicBindHandle(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = A_10 + 1;
			A_10 = num;
			bool flag = A_10 < A_7.childCount;
			A_23 = flag;
			int num2 = (A_23 ? 1 : 0) * -18 + 37;
			A_0 = num2;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001A068 File Offset: 0x00018268
		private static void removeDesignerNamespaceResolveEvidenceTypeGenerated(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			float num = Vector3.Distance(A_17.rightHandTransform.position, A_14.position);
			A_19 = num;
			float num2 = Vector3.Distance(A_17.leftHandTransform.position, A_14.position);
			A_20 = num2;
			float num3 = 0.5f;
			A_21 = num3;
			int num4 = (((A_19 < A_21) * true) ? 1 : 0) + 25;
			A_0 = num4;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001A128 File Offset: 0x00018328
		private static void getANSICodePageSecureStringToGlobalAllocAnsi(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_16 = enumerator;
			A_0 = 22;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001A164 File Offset: 0x00018364
		private static void BindTypeEventFieldTags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001A17C File Offset: 0x0001837C
		private static void EncryptAddChannel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001A194 File Offset: 0x00018394
		private static void ChannelUrisYield(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			bool flag = false;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 4 + 346;
			A_0 = num;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001A1F0 File Offset: 0x000183F0
		public static void WallWalk()
		{
			int num = 216;
			int num2 = 216;
			num2 = 216;
			while (num2 != 0)
			{
				int num3;
				RaycastHit raycastHit;
				RaycastHit raycastHit2;
				bool flag;
				bool flag2;
				bool flag3;
				Vector3 vector;
				Vector3 vector2;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				Vector3 vector3;
				bool flag8;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.RaycastHit&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.Vector3&,System.Boolean&), ref num, ref num2, ref num3, ref raycastHit, ref raycastHit2, ref flag, ref flag2, ref flag3, ref vector, ref vector2, ref flag4, ref flag5, ref flag6, ref flag7, ref vector3, ref flag8, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 216;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001A24C File Offset: 0x0001844C
		private static void BrtrueILAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local = GameObject.CreatePrimitive(3);
			Mods.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 451;
			A_0 = num;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001A2D8 File Offset: 0x000184D8
		private static void LeaseManagerPollTimeRealErrorObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.4f";
			bool flag = Mods.DickIsTiny == 17;
			A_21 = flag;
			int num = ((!A_21) ? 1 : 0) * 1 + 195;
			A_0 = num;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001A37C File Offset: 0x0001857C
		public unsafe static void Beacons()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 43;
			int num4 = 43;
			num4 = 43;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 43;
						if ((int)array[7] != 1)
						{
							num5 = (int)array[2];
							num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 72 + num2);
							for (num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + *(ref CodePageXsdType.IProgressInheritedObjectAceType + (int)array[5] + 72 + num2) + 72 + num2); num7 != num6; num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num7 + 72 + num2))
							{
								num8 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num7 + 64 + num2);
								if (num8 != -1)
								{
									num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num8 + 24 + num2);
									array[5] = num8;
									array[1] = 2;
									num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num8 + 24 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[4];
							num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
							ex2 = ex;
							array = (object[])array[3];
							array2 = new object[]
							{
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								0
							};
							array2[3] = array;
							array2[4] = ex;
							array2[5] = num5;
							array2[1] = 0;
							array = array2;
							num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
							continue;
						}
						num10 = (int)array[0];
						array = (object[])array[3];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							GameObject gameObject;
							LineRenderer lineRenderer;
							bool flag2;
							GradientColorKey[] array3;
							ColorChanger colorChanger;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.LineRenderer&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, ref gameObject, ref lineRenderer, ref flag2, ref array3, ref colorChanger, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 43;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num15 * 72 + 64 + num2);
						num17 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num15 * 72 + 32 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num7 * 72 + 48 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num14 * 72 + 64 + num2);
						num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num14 * 72 + 32 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num7 * 72 + 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num15 * 56 + 48 + num2);
						num17 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num15 * 56 + 24 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num7 * 56 + 32 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D6:
						if (array == null || (int)array[7] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 72 + num2);
								}
								else
								{
									num10 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 64 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 72 + num2);
									goto IL_9D6;
								}
							}
							goto IL_B74;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 24 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num15 * 56 + 48 + num2);
								num10 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num15 * 56 + 24 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num5 * 56 + 32 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num7 + 72 + num2);
								}
								else
								{
									num5 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 64 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 72 + num2);
									goto IL_9D6;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[3];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[3] = array;
					array2[0] = num11;
					array2[5] = num5;
					array2[1] = 2;
					array = array2;
					num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B74:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 24 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[3] = array;
					array2[0] = num11;
					array2[5] = num10;
					array2[1] = 2;
					array = array2;
					num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 24 + num2);
				}
				num4 = 43;
				return;
				IL_1BC:
				if (num6 != -1)
				{
					goto IL_1C7;
				}
				goto IL_3F1;
				IL_1C7:
				num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 40 + num2);
				if (4 == num7)
				{
					goto IL_1E6;
				}
				if (2 == num7)
				{
					goto IL_378;
				}
				goto IL_3F1;
				IL_1E6:
				num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 64 + num2);
				if (num9 == -1)
				{
					goto IL_234;
				}
				Type[] array4;
				Type type;
				if ((type = array4[num9]) != null)
				{
					goto IL_21A;
				}
				RuntimeTypeHandle[] array5;
				array4[num9] = Type.GetTypeFromHandle(array5[num9]);
				type = array4[num9];
				IL_21A:
				if (type.IsInstanceOfType(array2[4]))
				{
					goto IL_234;
				}
				num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 56 + num2);
				goto IL_1BC;
				IL_234:
				num5 = num6;
				num8 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 72 + num2) + 72 + num2);
				num13 = (int)array2[6];
				IL_258:
				if (num13 != num8)
				{
					goto IL_2D7;
				}
				int num22 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
				ex2 = array2[4];
				array = (object[])array[3];
				object[] array6 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array6[3] = array;
				array6[4] = array2[4];
				array6[6] = (int)array2[6];
				array6[5] = num5;
				array6[1] = 0;
				array = array6;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
				goto IL_1A;
				IL_2D7:
				num18 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num13 + 64 + num2);
				if (num18 == -1)
				{
					goto IL_366;
				}
				num22 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 24 + num2);
				array = (object[])array[3];
				array6 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array6[3] = array;
				array6[4] = array2[4];
				array6[6] = (int)array2[6];
				array6[5] = num18;
				array6[2] = num5;
				array6[1] = 2;
				array = array6;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num18 + 24 + num2);
				goto IL_1A;
				IL_366:
				num13 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num13 + 72 + num2);
				goto IL_258;
				IL_378:
				num22 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 48 + num2);
				ex2 = array2[4];
				array = (object[])array[3];
				array6 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array6[3] = array;
				array6[4] = array2[4];
				array6[6] = (int)array2[6];
				array6[5] = num6;
				array6[1] = 1;
				array = array6;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num6 + 48 + num2);
				goto IL_1A;
				IL_3F1:
				array = (object[])array[3];
				Exception ex3 = array2[4];
				int num23 = (int)array2[6];
				IL_410:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_41E:
				num14 = (num21 + num10) / 2;
				num15 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num14 * 72 + 64 + num2);
				num16 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num14 * 72 + 32 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_464;
				}
				if (num15 > num22)
				{
					goto IL_46C;
				}
				num8 = num14;
				num5 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 176 + num8 * 72 + 48 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_494;
				IL_464:
				num21 = num14 + 1;
				goto IL_41E;
				IL_46C:
				num10 = num14 - 1;
				goto IL_41E;
				IL_494:
				if (array != null)
				{
					goto IL_49F;
				}
				goto IL_62E;
				IL_49F:
				if ((int)array[7] != 1)
				{
					goto IL_55F;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4C3;
				}
				int num25 = -1;
				goto IL_546;
				IL_4C3:
				num17 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num9 + 24 + num2);
				num16 = 0;
				num15 = 2;
				IL_4D6:
				num14 = (num16 + num15) / 2;
				num10 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num14 * 56 + 48 + num2);
				num21 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num14 * 56 + 24 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_51C;
				}
				if (num10 > num17)
				{
					goto IL_524;
				}
				num5 = num14;
				num8 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num5 * 56 + 32 + num2);
				num25 = num8;
				goto IL_546;
				IL_51C:
				num16 = num14 + 1;
				goto IL_4D6;
				IL_524:
				num15 = num14 - 1;
				goto IL_4D6;
				IL_546:
				if (num24 != num25)
				{
					goto IL_54E;
				}
				goto IL_62E;
				IL_54E:
				array = (object[])array[3];
				goto IL_494;
				IL_55F:
				num18 = (int)array[1];
				if (num18 == 0 || num18 == 2)
				{
					goto IL_580;
				}
				if (num18 != 1)
				{
					goto IL_57F;
				}
				array2 = array;
				num6 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + (int)array2[5] + 56 + num2);
				goto IL_1BC;
				IL_57F:
				IL_580:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_595;
				}
				int num27 = -1;
				goto IL_618;
				IL_595:
				num22 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num9 + 24 + num2);
				num21 = 0;
				num10 = 2;
				IL_5A8:
				num14 = (num21 + num10) / 2;
				num15 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num14 * 56 + 48 + num2);
				num16 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num14 * 56 + 24 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5EE;
				}
				if (num15 > num22)
				{
					goto IL_5F6;
				}
				num8 = num14;
				num5 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + 392 + num8 * 56 + 32 + num2);
				num27 = num5;
				goto IL_618;
				IL_5EE:
				num21 = num14 + 1;
				goto IL_5A8;
				IL_5F6:
				num10 = num14 - 1;
				goto IL_5A8;
				IL_618:
				if (num26 != num27)
				{
					goto IL_61D;
				}
				goto IL_62E;
				IL_61D:
				array = (object[])array[3];
				goto IL_494;
				IL_62E:
				if (-1 != num9)
				{
					goto IL_63A;
				}
				int num28 = 1;
				throw ex3;
				IL_63A:
				num7 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num9 + 40 + num2);
				num10 = num7;
				IL_64B:
				if (num10 != -1)
				{
					goto IL_662;
				}
				num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num9 + 72 + num2);
				goto IL_494;
				IL_662:
				num15 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 40 + num2);
				if (4 == num15)
				{
					goto IL_68D;
				}
				if (2 == num15)
				{
					goto IL_7FB;
				}
				num9 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num9 + 72 + num2);
				goto IL_494;
				IL_68D:
				num14 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 64 + num2);
				if (num14 == -1)
				{
					goto IL_6DC;
				}
				Type type2;
				if ((type2 = array4[num14]) != null)
				{
					goto IL_6C1;
				}
				array4[num14] = Type.GetTypeFromHandle(array5[num14]);
				type2 = array4[num14];
				IL_6C1:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6DC;
				}
				num10 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 56 + num2);
				goto IL_64B;
				IL_6DC:
				num5 = num10;
				num8 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 72 + num2) + 72 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_705:
				if (num17 != num8)
				{
					goto IL_76E;
				}
				num21 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[4] = ex3;
				array2[6] = num13;
				array2[5] = num5;
				array2[1] = 0;
				array = array2;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num5 + 24 + num2);
				goto IL_1A;
				IL_76E:
				num16 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num17 + 64 + num2);
				if (num16 == -1)
				{
					goto IL_7E9;
				}
				num21 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num16 + 24 + num2);
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[4] = ex3;
				array2[6] = num13;
				array2[5] = num16;
				array2[2] = num5;
				array2[1] = 2;
				array = array2;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num16 + 24 + num2);
				goto IL_1A;
				IL_7E9:
				num17 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num17 + 72 + num2);
				goto IL_705;
				IL_7FB:
				num21 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 48 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[4] = ex3;
				array2[6] = num13;
				array2[5] = num10;
				array2[1] = 1;
				array = array2;
				num3 = *(ref CodePageXsdType.IProgressInheritedObjectAceType + num10 + 48 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_410;
				}
				throw ex4;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001AFB8 File Offset: 0x000191B8
		private static void listHashElements(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 1;
			A_2 = 108;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001AFDC File Offset: 0x000191DC
		private static void FieldAccessMaskgetXmlFieldOrder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_0 = 149;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001B030 File Offset: 0x00019230
		private static void ISymbolDocumentgetEventHandle(ref int A_0, ref int A_1, ref int A_2)
		{
			VRMap head = RigShit.GetOwnVRRig().head;
			head.trackingRotationOffset.y = head.trackingRotationOffset.y + 15f;
			A_1 = 2;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0001B068 File Offset: 0x00019268
		private static void setPercentPositivePatternOffsetAndRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001B098 File Offset: 0x00019298
		private static void getScheduledConcurrentSecurityRegistryPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(999f, 999f, 999f);
			A_0 = 302;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public static void SizeChanger()
		{
			int num = 206;
			int num2 = 206;
			num2 = 206;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 206;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001B120 File Offset: 0x00019320
		private static void DXNNYCollection(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(1);
			A_1 = 0;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001B14C File Offset: 0x0001934C
		private static void ITracingStatusChangedEventArgsAllocHGlobal(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 5;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001B174 File Offset: 0x00019374
		private static void TextElementEnumeratorTrusted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 17;
			A_22 = flag;
			int num = ((!A_22) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001B1D8 File Offset: 0x000193D8
		private static void getMaximumAgeUnitGetCOMIUnknown(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 5;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 370;
			A_0 = num;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001B23C File Offset: 0x0001943C
		private static void JitImmediateControlBreak(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.4f";
			bool flag = Mods.DickIsTiny == 11;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 183;
			A_0 = num;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001B2E0 File Offset: 0x000194E0
		private static void PersianCalendarIterationCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_local.GetComponent<Renderer>());
			Mods.jump_left_local.transform.localScale = Mods.scale;
			Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			Mods.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			Mods.once_left = true;
			Mods.once_left_false = false;
			ColorChanger colorChanger = Mods.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = Mods.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 458;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001B4A4 File Offset: 0x000196A4
		private static void ObjectMarshalerIDescriptionMetadataEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			bool changingColors = Mods.ChangingColors;
			A_15 = changingColors;
			int num = ((!A_15) ? 1 : 0) * 1 + 89;
			A_0 = num;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001B500 File Offset: 0x00019700
		private static void CoClassAttributesetViewAndModify(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaiseEventOptions A_4, ref RaiseEventOptions A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001B518 File Offset: 0x00019718
		private static void ArgumentOutOfRangeExceptionCCMPWPASCAL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Time.time > Mods.Deli;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 393;
			A_0 = num;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001B57C File Offset: 0x0001977C
		public unsafe static void ReportLeave()
		{
			RuntimeTypeHandle[] array = new RuntimeTypeHandle[1];
			Type[] array2 = new Type[1];
			array[0] = typeof(object).TypeHandle;
			int num = 1;
			int num2 = num * 4;
			int num3 = 13;
			int num4 = 13;
			num4 = 13;
			try
			{
				IL_36:
				object[] array3;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array4;
				int num10;
				int num18;
				int num19;
				int num20;
				int num21;
				int num22;
				int num23;
				int num26;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 13;
						if ((int)array3[2] != 0)
						{
							num5 = (int)array3[4];
							num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 32 + num2);
							for (num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + (int)array3[7] + 32 + num2) + 16 + num2); num7 != num6; num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num7 + 16 + num2))
							{
								num8 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num7 + 56 + num2);
								if (num8 != -1)
								{
									num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num8 + 24 + num2);
									array3[7] = num8;
									array3[1] = 1;
									num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num8 + 24 + num2);
									goto IL_36;
								}
							}
							Exception ex = (Exception)array3[3];
							num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
							ex2 = ex;
							array3 = (object[])array3[6];
							array4 = new object[8];
							array4[2] = 1;
							array4[6] = array3;
							array4[3] = ex;
							array4[7] = num5;
							array4[1] = 0;
							array3 = array4;
							num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
							continue;
						}
						num10 = (int)array3[0];
						array3 = (object[])array3[6];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							GameObject gameObject;
							Transform transform;
							int num13;
							Transform transform2;
							bool flag;
							string text;
							int num14;
							Transform transform3;
							bool flag2;
							Text text2;
							Transform transform4;
							bool flag3;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag4;
							float num15;
							float num16;
							float num17;
							bool flag5;
							bool flag6;
							bool flag7;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,UnityEngine.GameObject&,UnityEngine.Transform&,System.Int32&,UnityEngine.Transform&,System.Boolean&,System.String&,System.Int32&,UnityEngine.Transform&,System.Boolean&,UnityEngine.UI.Text&,UnityEngine.Transform&,System.Boolean&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Single&,System.Single&,System.Single&,System.Boolean&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref gameObject, ref transform, ref num13, ref transform2, ref flag, ref text, ref num14, ref transform3, ref flag2, ref text2, ref transform4, ref flag3, ref enumerator, ref vrrig, ref flag4, ref num15, ref num16, ref num17, ref flag5, ref flag6, ref flag7, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 13;
						num8 = num12;
						num11 = num8;
					}
					num18 = num3;
					num6 = num18;
					num10 = 0;
					num19 = 4;
					for (;;)
					{
						num20 = (num10 + num19) / 2;
						num21 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num20 * 80 + 24 + num2);
						num22 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num20 * 80 + 56 + num2);
						if (num6 < num21 + num22)
						{
							if (num21 <= num6)
							{
								break;
							}
							num19 = num20 - 1;
						}
						else
						{
							num10 = num20 + 1;
						}
					}
					num7 = num20;
					num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num7 * 80 + 72 + num2);
					num23 = num9;
					num22 = num11;
					num21 = 0;
					num20 = 4;
					for (;;)
					{
						num19 = (num21 + num20) / 2;
						num10 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num19 * 80 + 24 + num2);
						num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num19 * 80 + 56 + num2);
						if (num22 < num10 + num6)
						{
							if (num10 <= num22)
							{
								break;
							}
							num20 = num19 - 1;
						}
						else
						{
							num21 = num19 + 1;
						}
					}
					num7 = num19;
					num8 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num7 * 80 + 72 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num19 = 4;
					for (;;)
					{
						num20 = (num10 + num19) / 2;
						num21 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num20 * 56 + 16 + num2);
						num22 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num20 * 56 + 40 + num2);
						if (num6 < num21 + num22)
						{
							if (num21 <= num6)
							{
								break;
							}
							num19 = num20 - 1;
						}
						else
						{
							num10 = num20 + 1;
						}
					}
					num7 = num20;
					num5 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num7 * 56 + 48 + num2);
					num8 = num5;
					for (;;)
					{
						IL_A4B:
						if (array3 == null || (int)array3[2] == 0)
						{
							num6 = num9;
							while (num6 != num23)
							{
								if (num6 != -1)
								{
									num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 16 + num2);
								}
								else
								{
									num10 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 56 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num23 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 16 + num2);
									goto IL_A4B;
								}
							}
							goto IL_BF5;
						}
						int num24 = (int)array3[7];
						int num25;
						if (num23 == -1)
						{
							num25 = -1;
						}
						else
						{
							num26 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 8 + num2);
							num22 = 0;
							num21 = 4;
							for (;;)
							{
								num20 = (num22 + num21) / 2;
								num19 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num20 * 56 + 16 + num2);
								num10 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num20 * 56 + 40 + num2);
								if (num26 < num19 + num10)
								{
									if (num19 <= num26)
									{
										break;
									}
									num21 = num20 - 1;
								}
								else
								{
									num22 = num20 + 1;
								}
							}
							num5 = num20;
							num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num5 * 56 + 48 + num2);
							num25 = num7;
						}
						if (num24 == num25)
						{
							num7 = num9;
							while (num7 != num23)
							{
								if (num7 != -1)
								{
									num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num7 + 16 + num2);
								}
								else
								{
									num5 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 56 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num23 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 16 + num2);
									goto IL_A4B;
								}
							}
							break;
						}
						if ((int)array3[7] == num8)
						{
							goto Block_55;
						}
						array3 = (object[])array3[6];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
					array4 = new object[8];
					array4[2] = 0;
					array4[6] = array3;
					array4[0] = num11;
					array4[7] = num5;
					array4[1] = 1;
					array3 = array4;
					num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_BF5:
					num3 = num11;
					continue;
					Block_58:
					num19 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 24 + num2);
					array4 = new object[8];
					array4[2] = 0;
					array4[6] = array3;
					array4[0] = num11;
					array4[7] = num10;
					array4[1] = 1;
					array3 = array4;
					num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 24 + num2);
				}
				num4 = 13;
				return;
				IL_1FF:
				if (num6 != -1)
				{
					goto IL_20A;
				}
				goto IL_443;
				IL_20A:
				num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 72 + num2);
				if (1 == num7)
				{
					goto IL_22A;
				}
				if (3 == num7)
				{
					goto IL_3C7;
				}
				goto IL_443;
				IL_22A:
				num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 88 + num2);
				if (num9 == -1)
				{
					goto IL_276;
				}
				Type type;
				if ((type = array2[num9]) != null)
				{
					goto IL_25B;
				}
				array2[num9] = Type.GetTypeFromHandle(array[num9]);
				type = array2[num9];
				IL_25B:
				if (type.IsInstanceOfType(array4[3]))
				{
					goto IL_276;
				}
				num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 64 + num2);
				goto IL_1FF;
				IL_276:
				num5 = num6;
				num8 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 32 + num2) + 16 + num2);
				num18 = (int)array4[5];
				IL_29C:
				if (num18 != num8)
				{
					goto IL_31E;
				}
				int num27 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
				ex2 = array4[3];
				array3 = (object[])array3[6];
				object[] array5 = new object[8];
				array5[2] = 1;
				array5[6] = array3;
				array5[3] = array4[3];
				array5[5] = (int)array4[5];
				array5[7] = num5;
				array5[1] = 0;
				array3 = array5;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
				goto IL_36;
				IL_31E:
				num23 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num18 + 56 + num2);
				if (num23 == -1)
				{
					goto IL_3B4;
				}
				num27 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 24 + num2);
				array3 = (object[])array3[6];
				array5 = new object[8];
				array5[2] = 1;
				array5[6] = array3;
				array5[3] = array4[3];
				array5[5] = (int)array4[5];
				array5[7] = num23;
				array5[4] = num5;
				array5[1] = 1;
				array3 = array5;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num23 + 24 + num2);
				goto IL_36;
				IL_3B4:
				num18 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num18 + 16 + num2);
				goto IL_29C;
				IL_3C7:
				num27 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 40 + num2);
				ex2 = array4[3];
				array3 = (object[])array3[6];
				array5 = new object[8];
				array5[2] = 1;
				array5[6] = array3;
				array5[3] = array4[3];
				array5[5] = (int)array4[5];
				array5[7] = num6;
				array5[1] = 2;
				array3 = array5;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num6 + 40 + num2);
				goto IL_36;
				IL_443:
				array3 = (object[])array3[6];
				Exception ex3 = array4[3];
				int num28 = (int)array4[5];
				IL_462:
				num6 = num3;
				num27 = num6;
				num26 = 0;
				num10 = 4;
				IL_471:
				num19 = (num26 + num10) / 2;
				num20 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num19 * 80 + 24 + num2);
				num21 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num19 * 80 + 56 + num2);
				if (num27 >= num20 + num21)
				{
					goto IL_4B9;
				}
				if (num20 > num27)
				{
					goto IL_4C1;
				}
				num8 = num19;
				num5 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 320 + num8 * 80 + 72 + num2);
				num9 = num5;
				num18 = num9;
				goto IL_4EA;
				IL_4B9:
				num26 = num19 + 1;
				goto IL_471;
				IL_4C1:
				num10 = num19 - 1;
				goto IL_471;
				IL_4EA:
				if (array3 != null)
				{
					goto IL_4F5;
				}
				goto IL_68A;
				IL_4F5:
				if ((int)array3[2] != 0)
				{
					goto IL_5B8;
				}
				int num29 = (int)array3[7];
				if (num9 != -1)
				{
					goto IL_519;
				}
				int num30 = -1;
				goto IL_59F;
				IL_519:
				num22 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num9 + 8 + num2);
				num21 = 0;
				num20 = 4;
				IL_52C:
				num19 = (num21 + num20) / 2;
				num10 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num19 * 56 + 16 + num2);
				num26 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num19 * 56 + 40 + num2);
				if (num22 >= num10 + num26)
				{
					goto IL_574;
				}
				if (num10 > num22)
				{
					goto IL_57C;
				}
				num5 = num19;
				num8 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num5 * 56 + 48 + num2);
				num30 = num8;
				goto IL_59F;
				IL_574:
				num21 = num19 + 1;
				goto IL_52C;
				IL_57C:
				num20 = num19 - 1;
				goto IL_52C;
				IL_59F:
				if (num29 != num30)
				{
					goto IL_5A7;
				}
				goto IL_68A;
				IL_5A7:
				array3 = (object[])array3[6];
				goto IL_4EA;
				IL_5B8:
				num23 = (int)array3[1];
				if (num23 == 0 || num23 == 1)
				{
					goto IL_5D9;
				}
				if (num23 != 2)
				{
					goto IL_5D8;
				}
				array4 = array3;
				num6 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + (int)array4[7] + 64 + num2);
				goto IL_1FF;
				IL_5D8:
				IL_5D9:
				int num31 = (int)array3[7];
				if (num9 != -1)
				{
					goto IL_5EE;
				}
				int num32 = -1;
				goto IL_674;
				IL_5EE:
				num27 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num9 + 8 + num2);
				num26 = 0;
				num10 = 4;
				IL_601:
				num19 = (num26 + num10) / 2;
				num20 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num19 * 56 + 16 + num2);
				num21 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num19 * 56 + 40 + num2);
				if (num27 >= num20 + num21)
				{
					goto IL_649;
				}
				if (num20 > num27)
				{
					goto IL_651;
				}
				num8 = num19;
				num5 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + 720 + num8 * 56 + 48 + num2);
				num32 = num5;
				goto IL_674;
				IL_649:
				num26 = num19 + 1;
				goto IL_601;
				IL_651:
				num10 = num19 - 1;
				goto IL_601;
				IL_674:
				if (num31 != num32)
				{
					goto IL_679;
				}
				goto IL_68A;
				IL_679:
				array3 = (object[])array3[6];
				goto IL_4EA;
				IL_68A:
				if (-1 != num9)
				{
					goto IL_696;
				}
				int num33 = 1;
				throw ex3;
				IL_696:
				num7 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num9 + 48 + num2);
				num10 = num7;
				IL_6A8:
				if (num10 != -1)
				{
					goto IL_6C0;
				}
				num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num9 + 16 + num2);
				goto IL_4EA;
				IL_6C0:
				num20 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 72 + num2);
				if (1 == num20)
				{
					goto IL_6ED;
				}
				if (3 == num20)
				{
					goto IL_863;
				}
				num9 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num9 + 16 + num2);
				goto IL_4EA;
				IL_6ED:
				num19 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 88 + num2);
				if (num19 == -1)
				{
					goto IL_73A;
				}
				Type type2;
				if ((type2 = array2[num19]) != null)
				{
					goto IL_71E;
				}
				array2[num19] = Type.GetTypeFromHandle(array[num19]);
				type2 = array2[num19];
				IL_71E:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_73A;
				}
				num10 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 64 + num2);
				goto IL_6A8;
				IL_73A:
				num5 = num10;
				num8 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 32 + num2) + 16 + num2);
				num22 = (num18 - num28) * ((num28 == -1) ? 1 : 0) + num28;
				IL_765:
				if (num22 != num8)
				{
					goto IL_7D1;
				}
				num26 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[2] = 1;
				array4[6] = array3;
				array4[3] = ex3;
				array4[5] = num18;
				array4[7] = num5;
				array4[1] = 0;
				array3 = array4;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num5 + 24 + num2);
				goto IL_36;
				IL_7D1:
				num21 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num22 + 56 + num2);
				if (num21 == -1)
				{
					goto IL_850;
				}
				num26 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num21 + 24 + num2);
				array4 = new object[8];
				array4[2] = 1;
				array4[6] = array3;
				array4[3] = ex3;
				array4[5] = num18;
				array4[7] = num21;
				array4[4] = num5;
				array4[1] = 1;
				array3 = array4;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num21 + 24 + num2);
				goto IL_36;
				IL_850:
				num22 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num22 + 16 + num2);
				goto IL_765;
				IL_863:
				num26 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 40 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[2] = 1;
				array4[6] = array3;
				array4[3] = ex3;
				array4[5] = num18;
				array4[7] = num10;
				array4[1] = 2;
				array3 = array4;
				num3 = *(ref SymCustomAttrToShortDateString.IVectorViewToIReadOnlyListAdapterIIDENTITYAUTHORITYREFERENCEIDENTITYTOTEXTFLAGCANONICAL + num10 + 40 + num2);
				goto IL_36;
			}
			catch (Exception ex4)
			{
				int num33;
				if (num33 != 1)
				{
					Exception ex3 = ex4;
					int num28 = -1;
					goto IL_462;
				}
				throw ex4;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001C23C File Offset: 0x0001A43C
		public unsafe static void CollidePlayers()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 99;
			int num4 = 99;
			num4 = 99;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 5)
					{
						num4 = 99;
						if ((int)array[1] != 0)
						{
							num5 = (int)array[7];
							num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + 8 + num2);
							for (num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + (int)array[0] + 8 + num2) + 8 + num2); num7 != num6; num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num7 + 8 + num2))
							{
								num8 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num7 + num2);
								if (num8 != -1)
								{
									num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num8 + num2);
									array[0] = num8;
									array[3] = 0;
									num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num8 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[4];
							num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[1] = 1;
							array2[2] = array;
							array2[4] = ex;
							array2[0] = num5;
							array2[3] = 2;
							array = array2;
							num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
							continue;
						}
						num10 = (int)array[6];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 1)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 99;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num15 * 40 + 8 + num2);
						num17 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num15 * 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num7 * 40 + 16 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num14 * 40 + 8 + num2);
						num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num14 * 40 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num7 * 40 + 16 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num15 * 40 + 8 + num2);
						num17 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num15 * 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num7 * 40 + 16 + num2);
					num8 = num5;
					for (;;)
					{
						IL_97B:
						if (array == null || (int)array[1] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 8 + num2);
								}
								else
								{
									num10 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + 8 + num2);
									goto IL_97B;
								}
							}
							goto IL_B09;
						}
						int num19 = (int)array[0];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + 24 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num15 * 40 + 8 + num2);
								num10 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num15 * 40 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num5 * 40 + 16 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num7 + 8 + num2);
								}
								else
								{
									num5 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + 8 + num2);
									goto IL_97B;
								}
							}
							break;
						}
						if ((int)array[0] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[2] = array;
					array2[6] = num11;
					array2[0] = num5;
					array2[3] = 0;
					array = array2;
					num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B09:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[2] = array;
					array2[6] = num11;
					array2[0] = num10;
					array2[3] = 0;
					array = array2;
					num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + num2);
				}
				num4 = 99;
				return;
				IL_19F:
				if (num6 != -1)
				{
					goto IL_1AA;
				}
				goto IL_3C2;
				IL_1AA:
				num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 16 + num2);
				if (1 == num7)
				{
					goto IL_1C9;
				}
				if (0 == num7)
				{
					goto IL_349;
				}
				goto IL_3C2;
				IL_1C9:
				num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 24 + num2);
				if (num9 == -1)
				{
					goto IL_217;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_1FD;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_1FD:
				if (type.IsInstanceOfType(array2[4]))
				{
					goto IL_217;
				}
				num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 40 + num2);
				goto IL_19F;
				IL_217:
				num5 = num6;
				num8 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + 8 + num2) + 8 + num2);
				num13 = (int)array2[5];
				IL_239:
				if (num13 != num8)
				{
					goto IL_2B2;
				}
				int num22 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
				ex2 = array2[4];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[1] = 1;
				array5[2] = array;
				array5[4] = array2[4];
				array5[5] = (int)array2[5];
				array5[0] = num5;
				array5[3] = 2;
				array = array5;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
				goto IL_1A;
				IL_2B2:
				num18 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num13 + num2);
				if (num18 == -1)
				{
					goto IL_338;
				}
				num22 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[1] = 1;
				array5[2] = array;
				array5[4] = array2[4];
				array5[5] = (int)array2[5];
				array5[0] = num18;
				array5[7] = num5;
				array5[3] = 0;
				array = array5;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num18 + num2);
				goto IL_1A;
				IL_338:
				num13 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num13 + 8 + num2);
				goto IL_239;
				IL_349:
				num22 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 32 + num2);
				ex2 = array2[4];
				array = (object[])array[2];
				array5 = new object[8];
				array5[1] = 1;
				array5[2] = array;
				array5[4] = array2[4];
				array5[5] = (int)array2[5];
				array5[0] = num6;
				array5[3] = 1;
				array = array5;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num6 + 32 + num2);
				goto IL_1A;
				IL_3C2:
				array = (object[])array[2];
				Exception ex3 = array2[4];
				int num23 = (int)array2[5];
				IL_3E1:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_3EF:
				num14 = (num21 + num10) / 2;
				num15 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num14 * 40 + 8 + num2);
				num16 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num14 * 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_431;
				}
				if (num15 > num22)
				{
					goto IL_439;
				}
				num8 = num14;
				num5 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 128 + num8 * 40 + 16 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_461;
				IL_431:
				num21 = num14 + 1;
				goto IL_3EF;
				IL_439:
				num10 = num14 - 1;
				goto IL_3EF;
				IL_461:
				if (array != null)
				{
					goto IL_46C;
				}
				goto IL_5F3;
				IL_46C:
				if ((int)array[1] != 0)
				{
					goto IL_528;
				}
				int num24 = (int)array[0];
				if (num9 != -1)
				{
					goto IL_490;
				}
				int num25 = -1;
				goto IL_50F;
				IL_490:
				num17 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num9 + 24 + num2);
				num16 = 0;
				num15 = 2;
				IL_4A3:
				num14 = (num16 + num15) / 2;
				num10 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num14 * 40 + 8 + num2);
				num21 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num14 * 40 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_4E5;
				}
				if (num10 > num17)
				{
					goto IL_4ED;
				}
				num5 = num14;
				num8 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num5 * 40 + 16 + num2);
				num25 = num8;
				goto IL_50F;
				IL_4E5:
				num16 = num14 + 1;
				goto IL_4A3;
				IL_4ED:
				num15 = num14 - 1;
				goto IL_4A3;
				IL_50F:
				if (num24 != num25)
				{
					goto IL_517;
				}
				goto IL_5F3;
				IL_517:
				array = (object[])array[2];
				goto IL_461;
				IL_528:
				num18 = (int)array[3];
				if (num18 == 2 || num18 == 0)
				{
					goto IL_549;
				}
				if (num18 != 1)
				{
					goto IL_548;
				}
				array2 = array;
				num6 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + (int)array2[0] + 40 + num2);
				goto IL_19F;
				IL_548:
				IL_549:
				int num26 = (int)array[0];
				if (num9 != -1)
				{
					goto IL_55E;
				}
				int num27 = -1;
				goto IL_5DD;
				IL_55E:
				num22 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num9 + 24 + num2);
				num21 = 0;
				num10 = 2;
				IL_571:
				num14 = (num21 + num10) / 2;
				num15 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num14 * 40 + 8 + num2);
				num16 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num14 * 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5B3;
				}
				if (num15 > num22)
				{
					goto IL_5BB;
				}
				num8 = num14;
				num5 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + 248 + num8 * 40 + 16 + num2);
				num27 = num5;
				goto IL_5DD;
				IL_5B3:
				num21 = num14 + 1;
				goto IL_571;
				IL_5BB:
				num10 = num14 - 1;
				goto IL_571;
				IL_5DD:
				if (num26 != num27)
				{
					goto IL_5E2;
				}
				goto IL_5F3;
				IL_5E2:
				array = (object[])array[2];
				goto IL_461;
				IL_5F3:
				if (-1 != num9)
				{
					goto IL_5FF;
				}
				int num28 = 1;
				throw ex3;
				IL_5FF:
				num7 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num9 + 16 + num2);
				num10 = num7;
				IL_610:
				if (num10 != -1)
				{
					goto IL_626;
				}
				num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num9 + 8 + num2);
				goto IL_461;
				IL_626:
				num15 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + 16 + num2);
				if (1 == num15)
				{
					goto IL_650;
				}
				if (0 == num15)
				{
					goto IL_7AC;
				}
				num9 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num9 + 8 + num2);
				goto IL_461;
				IL_650:
				num14 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + 24 + num2);
				if (num14 == -1)
				{
					goto IL_69F;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_684;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_684:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_69F;
				}
				num10 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + 40 + num2);
				goto IL_610;
				IL_69F:
				num5 = num10;
				num8 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + 8 + num2) + 8 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6C6:
				if (num17 != num8)
				{
					goto IL_729;
				}
				num21 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[1] = 1;
				array2[2] = array;
				array2[4] = ex3;
				array2[5] = num13;
				array2[0] = num5;
				array2[3] = 2;
				array = array2;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num5 + num2);
				goto IL_1A;
				IL_729:
				num16 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num17 + num2);
				if (num16 == -1)
				{
					goto IL_79B;
				}
				num21 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num16 + num2);
				array2 = new object[8];
				array2[1] = 1;
				array2[2] = array;
				array2[4] = ex3;
				array2[5] = num13;
				array2[0] = num16;
				array2[7] = num5;
				array2[3] = 0;
				array = array2;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num16 + num2);
				goto IL_1A;
				IL_79B:
				num17 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num17 + 8 + num2);
				goto IL_6C6;
				IL_7AC:
				num21 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + 32 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[1] = 1;
				array2[2] = array;
				array2[4] = ex3;
				array2[5] = num13;
				array2[0] = num10;
				array2[3] = 1;
				array = array2;
				num3 = *(ref EnumResultInlineMethod.EqualsExactSystemDefinedImpl + num10 + 32 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_3E1;
				}
				throw ex4;
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001CE00 File Offset: 0x0001B000
		private static void FormatIntgetMacCodePage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 0;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 360;
			A_0 = num;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001CE64 File Offset: 0x0001B064
		public static void MakePlayersBlack()
		{
			int num = 289;
			int num2 = 289;
			num2 = 289;
			while (num2 != 0)
			{
				int num3;
				VRRig[] array;
				int num4;
				VRRig vrrig;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,VRRig[]&,System.Int32&,VRRig&), ref num, ref num2, ref num3, ref array, ref num4, ref vrrig, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 289;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001CEAC File Offset: 0x0001B0AC
		public static void Change_User_Stuff()
		{
			int num = 130;
			int num2 = 130;
			num2 = 130;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 130;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
		private static void ReadCacheCompatibleFrameworksMetadataEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 442;
			A_0 = num;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001CF58 File Offset: 0x0001B158
		private static void CreatePermanentEventHandle(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 5;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001CF80 File Offset: 0x0001B180
		private static void BinaryWritergetIsTypeSpec(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			A_0 = 226;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001CF98 File Offset: 0x0001B198
		private static void HandlerLengthFromEventKeywords(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			Transform child = A_7.GetChild(A_10);
			A_11 = child;
			bool flag = A_11.name.Contains("GorillaPlayerScoreboardLine");
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 15 + 20;
			A_0 = num;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001D030 File Offset: 0x0001B230
		private static void DXNNYIMPLTYPEFLAGS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < Mods.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 462;
			A_0 = num2;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		public static void HeadSpin()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 2)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001D104 File Offset: 0x0001B304
		private static void AssemblyRefUCOMIStream(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 412;
			A_0 = num;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001D14C File Offset: 0x0001B34C
		private static void EVENTACTIVITYCTRLCREATESETIDStat(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.offlineVRRig.name = "_";
			GorillaComputer.instance.currentName = "_";
			A_1 = 0;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001D18C File Offset: 0x0001B38C
		private static void getIsGenericParameterConcurrentStackFastPushFailed(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_8.GetComponent<Renderer>().material.color = Color.black;
			Object.Destroy(A_7, Time.deltaTime);
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 73;
			A_0 = num;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001D208 File Offset: 0x0001B408
		private static void getContainsGenericParametersEncodedArrayType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_left ? 1 : 0) * 1 + 445;
			A_0 = num;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001D24C File Offset: 0x0001B44C
		private static void BuildNumberDelegateEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Mods.DickIsTiny = 0;
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001D27C File Offset: 0x0001B47C
		private static void GetXmlElementForInteropTypeDelete(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 6;
			A_2 = 288;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		private static void GenericPrincipalUniversalSortableDateTimePattern(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_local);
			Mods.jump_left_local = null;
			Mods.once_left = false;
			Mods.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 459;
			A_0 = num;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001D364 File Offset: 0x0001B564
		private static void InternalApplicationIdentityHelperQueueSegment(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 11;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 382;
			A_0 = num;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		private static void setPercentGroupSizesCleanupCode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
		public static void NoClip()
		{
			int num = 151;
			int num2 = 151;
			num2 = 151;
			while (num2 != 0)
			{
				int num3;
				MeshCollider[] array;
				int num4;
				MeshCollider meshCollider;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.MeshCollider[]&,System.Int32&,UnityEngine.MeshCollider&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref meshCollider, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 151;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001D42C File Offset: 0x0001B62C
		private static void SetLengthToFirstNullLoaderExceptions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_16 = array;
			A_16[0].color = Mods.FirstColor;
			A_16[0].time = 0f;
			A_16[1].color = Mods.FirstColor;
			A_16[1].time = 0.3f;
			A_16[2].color = Mods.SecondColor;
			A_16[2].time = 0.6f;
			A_16[3].color = Mods.SecondColor;
			A_16[3].time = 1f;
			ColorChanger colorChanger = A_11.AddComponent<ColorChanger>();
			A_17 = colorChanger;
			A_17.colors = new Gradient
			{
				colorKeys = A_16
			};
			A_17.Start();
			A_0 = 91;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001D59C File Offset: 0x0001B79C
		private static void DefaultNameClaimTyperangeManager(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 422;
			A_0 = num;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001D5E4 File Offset: 0x0001B7E4
		private static void EnumPrivateFilesLeaseManagerPollTime(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 1;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001D60C File Offset: 0x0001B80C
		private static void AsUintSoapAction(ref int A_0, ref int A_1, ref int A_2, ref GradientColorKey[] A_3, ref Gradient A_4, ref float A_5, ref Color A_6, ref bool A_7, ref bool A_8)
		{
			GradientColorKey[] array = new GradientColorKey[7];
			A_3 = array;
			A_3[0].color = Color.red;
			A_3[0].time = 0f;
			A_3[1].color = Color.yellow;
			A_3[1].time = 0.2f;
			A_3[2].color = Color.green;
			A_3[2].time = 0.3f;
			A_3[3].color = Color.cyan;
			A_3[3].time = 0.5f;
			A_3[4].color = Color.blue;
			A_3[4].time = 0.6f;
			A_3[5].color = Color.magenta;
			A_3[5].time = 0.8f;
			A_3[6].color = Color.red;
			A_3[6].time = 1f;
			Gradient gradient = new Gradient();
			A_4 = gradient;
			A_4.colorKeys = A_3;
			float num = Mathf.PingPong(Time.time / 2f, 1f);
			A_5 = num;
			Color color = A_4.Evaluate(A_5);
			A_6 = color;
			bool flag = GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId);
			A_7 = flag;
			bool flag2 = A_7;
			A_8 = flag2;
			int num2 = ((!A_8) ? 1 : 0) * 1 + 11;
			A_0 = num2;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001D8CC File Offset: 0x0001BACC
		private static void DSObjectAllgetDateTime(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			MeshCollider meshCollider = A_3[A_4];
			A_5 = meshCollider;
			bool triggerDownR = WristMenu.triggerDownR;
			A_6 = triggerDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 153;
			A_0 = num;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001D94C File Offset: 0x0001BB4C
		private static void InlineTokSystemAclAutoInherited(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 4;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 169;
			A_0 = num;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
		private static void getEncodedEnumTypeCompatibleComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 458;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001D9C8 File Offset: 0x0001BBC8
		private static void OFBIsolatedStorageSecurityState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
		private static void IsSingleBytegetBigEndianUnicode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 2;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 165;
			A_0 = num;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		private static void getAccessMuiResourceMapResourceTypeIdString(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -5 + 157;
			A_0 = num2;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001DABC File Offset: 0x0001BCBC
		private static void clsidNoOptimization(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			Object.Destroy(A_7, Time.deltaTime);
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 73;
			A_0 = num;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001DB18 File Offset: 0x0001BD18
		private static void IMapViewBLOB(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			RigShit.GetPlayerFromRig(GorillaTagger.Instance.offlineVRRig);
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0.1f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 30f, 0f);
			A_0 = 324;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		private static void FieldAccessMaskDeploymentMetadataEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			bool changingColors = Mods.ChangingColors;
			A_13 = changingColors;
			int num = ((!A_13) ? 1 : 0) * 1 + 146;
			A_0 = num;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001DC0C File Offset: 0x0001BE0C
		private static void ByteTokenEncodingWaitingToRun(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 3 + 388;
			A_0 = num;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001DC68 File Offset: 0x0001BE68
		private static void ZeroFreeCoTaskMemAnsiGetHostEvidence(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 281;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001DCA4 File Offset: 0x0001BEA4
		private static void PfxStartListening(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		private static void MetadataSectionRequestedExecutionLevelUIAccessGetOrderablePartitions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 240;
			A_0 = num;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0001DD24 File Offset: 0x0001BF24
		private static void SetPublicKeyReadOnlyCollectionBase(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001DD80 File Offset: 0x0001BF80
		private static void ObjectWithMapWriteAttributes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 4;
			A_2 = 128;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		private static void XmlSegmentMAJORVERSION(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 156;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001DDEC File Offset: 0x0001BFEC
		private static void RegisteredChannelApplicationBasePath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 252;
			A_0 = num;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001DE48 File Offset: 0x0001C048
		public static void TeleportGun()
		{
			int num = 342;
			int num2 = 342;
			num2 = 342;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				bool flag2;
				bool flag3;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref flag2, ref flag3, ref array, ref colorChanger, ref flag4, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 342;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001DE98 File Offset: 0x0001C098
		private static void getDeclaredEventsSoapHexBinary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 8;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 376;
			A_0 = num;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001DEFC File Offset: 0x0001C0FC
		private static void DefineMethodOverrideJapaneseLunisolarCalendar(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * Mods.flySpeed;
			Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0001DF70 File Offset: 0x0001C170
		private static void DefineDefaultConstructorsetFirstPermissionThatFailed(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = A_6 + 1;
			A_6 = num;
			int num2 = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 426;
			A_0 = num2;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001DFD0 File Offset: 0x0001C1D0
		private static void setCurrencyGroupSizesPriority(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 1;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001DFF8 File Offset: 0x0001C1F8
		private static void TypesAlwaysIsPrimitive(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local.transform.localScale = Mods.scale;
			Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			Mods.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			Mods.once_right = true;
			Mods.once_right_false = false;
			ColorChanger colorChanger = Mods.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = Mods.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 443;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		private static void STAThreadAttributegetCondition(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.headMesh.transform.position = GorillaTagger.Instance.offlineVRRig.rightHandTransform.position;
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 277;
			A_0 = num;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001E224 File Offset: 0x0001C424
		private static void HashElementXmlGetHostSuppliedAssemblyEvidenceTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001E23C File Offset: 0x0001C43C
		private static void GetAssemblyIdentityMDStreamVersion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_24 = flag;
			int num2 = (A_24 ? 1 : 0) * -25 + 40;
			A_0 = num2;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		private static void RFCPatternManifestModule(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance == A_4.distance;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 233;
			A_0 = num;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001E33C File Offset: 0x0001C53C
		private static void getCergetHost(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.sizeScale <= 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 213;
			A_0 = num;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
		private static void PushiFullControl(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Physics.Raycast(Player.Instance.rightControllerTransform.position, -Player.Instance.rightControllerTransform.right, ref A_3, 100f, int.MaxValue);
			Physics.Raycast(Player.Instance.leftControllerTransform.position, Player.Instance.leftControllerTransform.right, ref A_4, 100f, int.MaxValue);
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_5 = rightGrab;
			int num = ((!A_5) ? 1 : 0) * 8 + 217;
			A_0 = num;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001E474 File Offset: 0x0001C674
		private static void FuncInvalidOperationRegRemoveSubKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 0, new object[]
			{
				4,
				false,
				999999f
			});
			Mods.FlushRemoteProceduralCalls();
			A_1 = 0;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001E4EC File Offset: 0x0001C6EC
		private static void ConstructorInfoOperationCompleted(ref int A_0, ref int A_1, ref int A_2)
		{
			RigShit.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
			A_1 = 0;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001E520 File Offset: 0x0001C720
		private static void IReflectOpCodes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 4 + 334;
			A_0 = num;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001E57C File Offset: 0x0001C77C
		private static void getDefaultValueTypeConstructorName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 442;
			A_0 = num;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001E5D8 File Offset: 0x0001C7D8
		private static void ToStringHelperFuncTreatAsSafe(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 11;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 1 + 384;
			A_0 = num;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001E63C File Offset: 0x0001C83C
		private static void getOriginalIssuerSecurityRuleSet(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance == A_4.distance;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 223;
			A_0 = num;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		private static void getIsOptionalLdfld(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_1 = 0;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001E6E0 File Offset: 0x0001C8E0
		private static void setTaskClass(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.GetComponent<Collider>().enabled = true;
			A_0 = 104;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001E714 File Offset: 0x0001C914
		private static void MulticastDelegateNotOnFaulted(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			A_0 = 236;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001E72C File Offset: 0x0001C92C
		private static void GetUnmanagedThunkForManagedMethodPtrLocalDateTime(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 44;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001E768 File Offset: 0x0001C968
		private static void IsLowerRevertDeny(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 110;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		private static void SingleDomainIKeyValuePair(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Slow";
			Mods.flySpeed = 5f;
			bool flag = Mods.TurnGay == 1;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 362;
			A_0 = num;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001E82C File Offset: 0x0001CA2C
		private static void ContainedInAnotherAssemblyVariantType(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 60;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0001E844 File Offset: 0x0001CA44
		private static void getPercentDecimalSeparatorSetLastAccessTimeUtc(ref int A_0, ref int A_1, ref int A_2, Mods A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001E868 File Offset: 0x0001CA68
		private static void ApplicationEvidenceSTORECATEGORY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			bool flag = Mods.pointer == null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 4 + 328;
			A_0 = num;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001E8CC File Offset: 0x0001CACC
		private static void AppDomainInitializerInfoIsSecured(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			bool flag = A_4 < 10;
			A_5 = flag;
			int num = (A_5 ? 1 : 0) * -2 + 250;
			A_0 = num;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001E934 File Offset: 0x0001CB34
		private static void ConvertTypeLibToAssemblyStoreDeploymentMetadataPropertyEnumeration(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.PlatformsThing(Mods.invisplat, Mods.stickyplatforms);
			A_1 = 0;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001E95C File Offset: 0x0001CB5C
		private static void getSystemConfigurationFileGetDayOfMonth(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.InvisiblePlatforms();
			Mods.WaterSplashHands();
			Mods.ColorWhite();
			A_1 = 0;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001E988 File Offset: 0x0001CB88
		private static void FilterNameFromOADate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_1 = 0;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0001E9C8 File Offset: 0x0001CBC8
		private static void LdelemaSTA(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0001E9E0 File Offset: 0x0001CBE0
		private static void getAttributeTypeCannotUnloadAppDomainException(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 426;
			A_0 = num;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		public static void AK47SoundSpam()
		{
			int num = 296;
			int num2 = 296;
			num2 = 296;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 296;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001EA60 File Offset: 0x0001CC60
		private static void ReflectionOnlyFinish(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_left_false ? 1 : 0) * 1 + 455;
			A_0 = num;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
		private static void getHostCanGenerategetMinimumRequiredVersion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 283;
			A_0 = num;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001EB30 File Offset: 0x0001CD30
		private static void IEnumDefinitionIdentityIntrospectiveSortUtilities(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 11;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 183;
			A_0 = num;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0001EB94 File Offset: 0x0001CD94
		private static void BneUnMuiResourceIdLookupMapEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_0 = 341;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001EC04 File Offset: 0x0001CE04
		private static void KindIsFromThisAppDomain(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 435;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		public static void BONKSoundSpam()
		{
			int num = 293;
			int num2 = 293;
			num2 = 293;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 293;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001EC70 File Offset: 0x0001CE70
		public unsafe static void DisableChams()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 55;
			int num4 = 55;
			num4 = 55;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 5)
					{
						num4 = 55;
						if ((int)array[5] != 1)
						{
							num5 = (int)array[0];
							num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 72 + num2);
							for (num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + (int)array[1] + 72 + num2) + 56 + num2); num7 != num6; num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num7 + 56 + num2))
							{
								num8 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num7 + 16 + num2);
								if (num8 != -1)
								{
									num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num8 + 48 + num2);
									array[1] = num8;
									array[3] = 2;
									num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num8 + 48 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[2];
							num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
							ex2 = ex;
							array = (object[])array[7];
							array2 = new object[]
							{
								null,
								null,
								null,
								null,
								null,
								0,
								null,
								array
							};
							array2[2] = ex;
							array2[1] = num5;
							array2[3] = 0;
							array = array2;
							num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
							continue;
						}
						num10 = (int)array[4];
						array = (object[])array[7];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 1)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 55;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num15 * 48 + 32 + num2);
						num17 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num15 * 48 + 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num7 * 48 + 8 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num14 * 48 + 32 + num2);
						num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num14 * 48 + 40 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num7 * 48 + 8 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num15 * 64 + 40 + num2);
						num17 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num15 * 64 + 56 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num7 * 64 + 8 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9C6:
						if (array == null || (int)array[5] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 56 + num2);
								}
								else
								{
									num10 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 16 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 56 + num2);
									goto IL_9C6;
								}
							}
							goto IL_B63;
						}
						int num19 = (int)array[1];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 40 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num15 * 64 + 40 + num2);
								num10 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num15 * 64 + 56 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num5 * 64 + 8 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num7 + 56 + num2);
								}
								else
								{
									num5 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 16 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 56 + num2);
									goto IL_9C6;
								}
							}
							break;
						}
						if ((int)array[1] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[7];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						1,
						null,
						array
					};
					array2[4] = num11;
					array2[1] = num5;
					array2[3] = 2;
					array = array2;
					num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B63:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 48 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						1,
						null,
						array
					};
					array2[4] = num11;
					array2[1] = num10;
					array2[3] = 2;
					array = array2;
					num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 48 + num2);
				}
				num4 = 55;
				return;
				IL_1B2:
				if (num6 != -1)
				{
					goto IL_1BD;
				}
				goto IL_3E7;
				IL_1BD:
				num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 96 + num2);
				if (3 == num7)
				{
					goto IL_1DC;
				}
				if (4 == num7)
				{
					goto IL_36E;
				}
				goto IL_3E7;
				IL_1DC:
				num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 24 + num2);
				if (num9 == -1)
				{
					goto IL_22A;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_210;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_210:
				if (type.IsInstanceOfType(array2[2]))
				{
					goto IL_22A;
				}
				num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 88 + num2);
				goto IL_1B2;
				IL_22A:
				num5 = num6;
				num8 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 72 + num2) + 56 + num2);
				num13 = (int)array2[6];
				IL_24E:
				if (num13 != num8)
				{
					goto IL_2CD;
				}
				int num22 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
				ex2 = array2[2];
				array = (object[])array[7];
				object[] array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[1] = num5;
				array5[3] = 0;
				array = array5;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
				goto IL_1A;
				IL_2CD:
				num18 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num13 + 16 + num2);
				if (num18 == -1)
				{
					goto IL_35C;
				}
				num22 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 48 + num2);
				array = (object[])array[7];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[1] = num18;
				array5[0] = num5;
				array5[3] = 2;
				array = array5;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num18 + 48 + num2);
				goto IL_1A;
				IL_35C:
				num13 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num13 + 56 + num2);
				goto IL_24E;
				IL_36E:
				num22 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 32 + num2);
				ex2 = array2[2];
				array = (object[])array[7];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array5[2] = array2[2];
				array5[6] = (int)array2[6];
				array5[1] = num6;
				array5[3] = 1;
				array = array5;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num6 + 32 + num2);
				goto IL_1A;
				IL_3E7:
				array = (object[])array[7];
				Exception ex3 = array2[2];
				int num23 = (int)array2[6];
				IL_406:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_414:
				num14 = (num21 + num10) / 2;
				num15 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num14 * 48 + 32 + num2);
				num16 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num14 * 48 + 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_45A;
				}
				if (num15 > num22)
				{
					goto IL_462;
				}
				num8 = num14;
				num5 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 184 + num8 * 48 + 8 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_489;
				IL_45A:
				num21 = num14 + 1;
				goto IL_414;
				IL_462:
				num10 = num14 - 1;
				goto IL_414;
				IL_489:
				if (array != null)
				{
					goto IL_494;
				}
				goto IL_621;
				IL_494:
				if ((int)array[5] != 1)
				{
					goto IL_553;
				}
				int num24 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_4B8;
				}
				int num25 = -1;
				goto IL_53A;
				IL_4B8:
				num17 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num9 + 40 + num2);
				num16 = 0;
				num15 = 2;
				IL_4CB:
				num14 = (num16 + num15) / 2;
				num10 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num14 * 64 + 40 + num2);
				num21 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num14 * 64 + 56 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_511;
				}
				if (num10 > num17)
				{
					goto IL_519;
				}
				num5 = num14;
				num8 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num5 * 64 + 8 + num2);
				num25 = num8;
				goto IL_53A;
				IL_511:
				num16 = num14 + 1;
				goto IL_4CB;
				IL_519:
				num15 = num14 - 1;
				goto IL_4CB;
				IL_53A:
				if (num24 != num25)
				{
					goto IL_542;
				}
				goto IL_621;
				IL_542:
				array = (object[])array[7];
				goto IL_489;
				IL_553:
				num18 = (int)array[3];
				if (num18 == 0 || num18 == 2)
				{
					goto IL_574;
				}
				if (num18 != 1)
				{
					goto IL_573;
				}
				array2 = array;
				num6 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + (int)array2[1] + 88 + num2);
				goto IL_1B2;
				IL_573:
				IL_574:
				int num26 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_589;
				}
				int num27 = -1;
				goto IL_60B;
				IL_589:
				num22 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num9 + 40 + num2);
				num21 = 0;
				num10 = 2;
				IL_59C:
				num14 = (num21 + num10) / 2;
				num15 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num14 * 64 + 40 + num2);
				num16 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num14 * 64 + 56 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5E2;
				}
				if (num15 > num22)
				{
					goto IL_5EA;
				}
				num8 = num14;
				num5 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + 328 + num8 * 64 + 8 + num2);
				num27 = num5;
				goto IL_60B;
				IL_5E2:
				num21 = num14 + 1;
				goto IL_59C;
				IL_5EA:
				num10 = num14 - 1;
				goto IL_59C;
				IL_60B:
				if (num26 != num27)
				{
					goto IL_610;
				}
				goto IL_621;
				IL_610:
				array = (object[])array[7];
				goto IL_489;
				IL_621:
				if (-1 != num9)
				{
					goto IL_62D;
				}
				int num28 = 1;
				throw ex3;
				IL_62D:
				num7 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num9 + 72 + num2);
				num10 = num7;
				IL_63E:
				if (num10 != -1)
				{
					goto IL_655;
				}
				num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num9 + 56 + num2);
				goto IL_489;
				IL_655:
				num15 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 96 + num2);
				if (3 == num15)
				{
					goto IL_680;
				}
				if (4 == num15)
				{
					goto IL_7EE;
				}
				num9 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num9 + 56 + num2);
				goto IL_489;
				IL_680:
				num14 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 24 + num2);
				if (num14 == -1)
				{
					goto IL_6CF;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6B4;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6B4:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6CF;
				}
				num10 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 88 + num2);
				goto IL_63E;
				IL_6CF:
				num5 = num10;
				num8 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 72 + num2) + 56 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6F8:
				if (num17 != num8)
				{
					goto IL_761;
				}
				num21 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array2[2] = ex3;
				array2[6] = num13;
				array2[1] = num5;
				array2[3] = 0;
				array = array2;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num5 + 48 + num2);
				goto IL_1A;
				IL_761:
				num16 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num17 + 16 + num2);
				if (num16 == -1)
				{
					goto IL_7DC;
				}
				num21 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num16 + 48 + num2);
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array2[2] = ex3;
				array2[6] = num13;
				array2[1] = num16;
				array2[0] = num5;
				array2[3] = 2;
				array = array2;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num16 + 48 + num2);
				goto IL_1A;
				IL_7DC:
				num17 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num17 + 56 + num2);
				goto IL_6F8;
				IL_7EE:
				num21 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 32 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					0,
					null,
					array
				};
				array2[2] = ex3;
				array2[6] = num13;
				array2[1] = num10;
				array2[3] = 1;
				array = array2;
				num3 = *(ref TOKENUSERISOModes.BltContractInvariantMethodAttribute + num10 + 32 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_406;
				}
				throw ex4;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0001F898 File Offset: 0x0001DA98
		private static void IProgIdRedirectionEntryMarshaledObject(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_1 = 0;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
		private static void setVersionAddedGetSingleArray(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_3 = playerListOthers;
			int num = 0;
			A_4 = num;
			A_0 = 78;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		private static void HandleCreateAnySchemeAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_6 = array;
			A_6[0].color = Mods.FirstColor;
			A_6[0].time = 0f;
			A_6[1].color = Mods.FirstColor;
			A_6[1].time = 0.3f;
			A_6[2].color = Mods.SecondColor;
			A_6[2].time = 0.6f;
			A_6[3].color = Mods.SecondColor;
			A_6[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_7 = colorChanger;
			A_7.colors = new Gradient
			{
				colorKeys = A_6
			};
			A_7.Start();
			A_0 = 137;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001FA64 File Offset: 0x0001DC64
		private static void HourgetDigestMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Faster";
			Mods.flySpeed = 40f;
			bool flag = Mods.TurnGay == 8;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 376;
			A_0 = num;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		private static void SZArrayEnumeratorInit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 5;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 171;
			A_0 = num;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0001FB50 File Offset: 0x0001DD50
		private static void ListDictionaryInternalConsoleCancelEventHandler(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_1 = 0;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001FB68 File Offset: 0x0001DD68
		private static void GetAtHaveSecond(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 422;
			A_0 = num;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		private static void GetSetMethodgetPublicOnly(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 3;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		public unsafe static void Chams()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 109;
			int num4 = 109;
			num4 = 109;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 109;
						if ((int)array[3] != 0)
						{
							num5 = (int)array[4];
							num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 24 + num2);
							for (num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + (int)array[6] + 24 + num2) + 24 + num2); num7 != num6; num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num7 + 24 + num2))
							{
								num8 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num7 + 48 + num2);
								if (num8 != -1)
								{
									num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num8 + 48 + num2);
									array[6] = num8;
									array[5] = 1;
									num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num8 + 48 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[0];
							num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[3] = 1;
							array2[2] = array;
							array2[0] = ex;
							array2[6] = num5;
							array2[5] = 2;
							array = array2;
							num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 109;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num15 * 72 + 24 + num2);
						num17 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num15 * 72 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num7 * 72 + 56 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num14 * 72 + 24 + num2);
						num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num14 * 72 + 16 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num7 * 72 + 56 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num15 * 72 + 24 + num2);
						num17 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num15 * 72 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num7 * 72 + 56 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9BD:
						if (array == null || (int)array[3] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + 24 + num2);
								}
								else
								{
									num10 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 48 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 24 + num2);
									goto IL_9BD;
								}
							}
							goto IL_B5B;
						}
						int num19 = (int)array[6];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 40 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num15 * 72 + 24 + num2);
								num10 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num15 * 72 + 16 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num5 * 72 + 56 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num7 + 24 + num2);
								}
								else
								{
									num5 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 48 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 24 + num2);
									goto IL_9BD;
								}
							}
							break;
						}
						if ((int)array[6] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[7] = num11;
					array2[6] = num5;
					array2[5] = 1;
					array = array2;
					num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B5B:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + 48 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[7] = num11;
					array2[6] = num10;
					array2[5] = 1;
					array = array2;
					num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + 48 + num2);
				}
				num4 = 109;
				return;
				IL_1B1:
				if (num6 != -1)
				{
					goto IL_1BC;
				}
				goto IL_3DF;
				IL_1BC:
				num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + 16 + num2);
				if (1 == num7)
				{
					goto IL_1DB;
				}
				if (2 == num7)
				{
					goto IL_36C;
				}
				goto IL_3DF;
				IL_1DB:
				num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + 56 + num2);
				if (num9 == -1)
				{
					goto IL_228;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_20F;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_20F:
				if (type.IsInstanceOfType(array2[0]))
				{
					goto IL_228;
				}
				num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + 8 + num2);
				goto IL_1B1;
				IL_228:
				num5 = num6;
				num8 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 24 + num2) + 24 + num2);
				num13 = (int)array2[1];
				IL_24C:
				if (num13 != num8)
				{
					goto IL_2CB;
				}
				int num22 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[1] = (int)array2[1];
				array5[6] = num5;
				array5[5] = 2;
				array = array5;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
				goto IL_1A;
				IL_2CB:
				num18 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num13 + 48 + num2);
				if (num18 == -1)
				{
					goto IL_35A;
				}
				num22 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 48 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[1] = (int)array2[1];
				array5[6] = num18;
				array5[4] = num5;
				array5[5] = 1;
				array = array5;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num18 + 48 + num2);
				goto IL_1A;
				IL_35A:
				num13 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num13 + 24 + num2);
				goto IL_24C;
				IL_36C:
				num22 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				array5 = new object[8];
				array5[3] = 1;
				array5[2] = array;
				array5[0] = array2[0];
				array5[1] = (int)array2[1];
				array5[6] = num6;
				array5[5] = 0;
				array = array5;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num6 + num2);
				goto IL_1A;
				IL_3DF:
				array = (object[])array[2];
				Exception ex3 = array2[0];
				int num23 = (int)array2[1];
				IL_3FE:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_40C:
				num14 = (num21 + num10) / 2;
				num15 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num14 * 72 + 24 + num2);
				num16 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num14 * 72 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_452;
				}
				if (num15 > num22)
				{
					goto IL_45A;
				}
				num8 = num14;
				num5 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 136 + num8 * 72 + 56 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_482;
				IL_452:
				num21 = num14 + 1;
				goto IL_40C;
				IL_45A:
				num10 = num14 - 1;
				goto IL_40C;
				IL_482:
				if (array != null)
				{
					goto IL_48D;
				}
				goto IL_61C;
				IL_48D:
				if ((int)array[3] != 0)
				{
					goto IL_54D;
				}
				int num24 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_4B1;
				}
				int num25 = -1;
				goto IL_534;
				IL_4B1:
				num17 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num9 + 40 + num2);
				num16 = 0;
				num15 = 2;
				IL_4C4:
				num14 = (num16 + num15) / 2;
				num10 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num14 * 72 + 24 + num2);
				num21 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num14 * 72 + 16 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_50A;
				}
				if (num10 > num17)
				{
					goto IL_512;
				}
				num5 = num14;
				num8 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num5 * 72 + 56 + num2);
				num25 = num8;
				goto IL_534;
				IL_50A:
				num16 = num14 + 1;
				goto IL_4C4;
				IL_512:
				num15 = num14 - 1;
				goto IL_4C4;
				IL_534:
				if (num24 != num25)
				{
					goto IL_53C;
				}
				goto IL_61C;
				IL_53C:
				array = (object[])array[2];
				goto IL_482;
				IL_54D:
				num18 = (int)array[5];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_56E;
				}
				if (num18 != 0)
				{
					goto IL_56D;
				}
				array2 = array;
				num6 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + (int)array2[6] + 8 + num2);
				goto IL_1B1;
				IL_56D:
				IL_56E:
				int num26 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_583;
				}
				int num27 = -1;
				goto IL_606;
				IL_583:
				num22 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num9 + 40 + num2);
				num21 = 0;
				num10 = 2;
				IL_596:
				num14 = (num21 + num10) / 2;
				num15 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num14 * 72 + 24 + num2);
				num16 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num14 * 72 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5DC;
				}
				if (num15 > num22)
				{
					goto IL_5E4;
				}
				num8 = num14;
				num5 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + 352 + num8 * 72 + 56 + num2);
				num27 = num5;
				goto IL_606;
				IL_5DC:
				num21 = num14 + 1;
				goto IL_596;
				IL_5E4:
				num10 = num14 - 1;
				goto IL_596;
				IL_606:
				if (num26 != num27)
				{
					goto IL_60B;
				}
				goto IL_61C;
				IL_60B:
				array = (object[])array[2];
				goto IL_482;
				IL_61C:
				if (-1 != num9)
				{
					goto IL_628;
				}
				int num28 = 1;
				throw ex3;
				IL_628:
				num7 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num9 + 16 + num2);
				num10 = num7;
				IL_639:
				if (num10 != -1)
				{
					goto IL_650;
				}
				num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num9 + 24 + num2);
				goto IL_482;
				IL_650:
				num15 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + 16 + num2);
				if (1 == num15)
				{
					goto IL_67B;
				}
				if (2 == num15)
				{
					goto IL_7E8;
				}
				num9 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num9 + 24 + num2);
				goto IL_482;
				IL_67B:
				num14 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + 56 + num2);
				if (num14 == -1)
				{
					goto IL_6C9;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6AF;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6AF:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6C9;
				}
				num10 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + 8 + num2);
				goto IL_639;
				IL_6C9:
				num5 = num10;
				num8 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 24 + num2) + 24 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6F2:
				if (num17 != num8)
				{
					goto IL_75B;
				}
				num21 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[1] = num13;
				array2[6] = num5;
				array2[5] = 2;
				array = array2;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num5 + 48 + num2);
				goto IL_1A;
				IL_75B:
				num16 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num17 + 48 + num2);
				if (num16 == -1)
				{
					goto IL_7D6;
				}
				num21 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num16 + 48 + num2);
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[1] = num13;
				array2[6] = num16;
				array2[4] = num5;
				array2[5] = 1;
				array = array2;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num16 + 48 + num2);
				goto IL_1A;
				IL_7D6:
				num17 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num17 + 24 + num2);
				goto IL_6F2;
				IL_7E8:
				num21 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[0] = ex3;
				array2[1] = num13;
				array2[6] = num10;
				array2[5] = 0;
				array = array2;
				num3 = *(ref FieldOnTypeBuilderInstantiationGetStringBuilder.getCurrentThreadgetPublicOnly + num10 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_3FE;
				}
				throw ex4;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000207F8 File Offset: 0x0001E9F8
		private static void MLangDecoderLongEnumEqualityComparer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			A_0 = 30;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00020810 File Offset: 0x0001EA10
		private static void ReadOnlyDictionaryKeyCollectiongetUseMachineKeyStore(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 4 + 46;
			A_0 = num;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0002089C File Offset: 0x0001EA9C
		public static void UpAndDown()
		{
			int num = 237;
			int num2 = 237;
			num2 = 237;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 237;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000208E4 File Offset: 0x0001EAE4
		private static void TraceLoggingMetadataCollectorSaturday(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000208FC File Offset: 0x0001EAFC
		private static void GetActivationFactorygetIsInterface(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool fix = Mods.Fix;
			A_4 = fix;
			int num = ((!A_4) ? 1 : 0) * 1 + 202;
			A_0 = num;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00020958 File Offset: 0x0001EB58
		private static void ExternalThreadingTypeInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			int num = ((!(A_5 != GorillaTagger.Instance.offlineVRRig)) ? 1 : 0) * 1 + 121;
			A_0 = num;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000209C8 File Offset: 0x0001EBC8
		public static void RainbowMonke()
		{
			int num = 10;
			int num2 = 10;
			num2 = 10;
			while (num2 != 0)
			{
				int num3;
				GradientColorKey[] array;
				Gradient gradient;
				float num4;
				Color color;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.GradientColorKey[]&,UnityEngine.Gradient&,System.Single&,UnityEngine.Color&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref gradient, ref num4, ref color, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 10;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00020A0C File Offset: 0x0001EC0C
		private static void setAsUintTNt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 15;
			A_19 = flag;
			int num = ((!A_19) ? 1 : 0) * 1 + 191;
			A_0 = num;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00020A70 File Offset: 0x0001EC70
		private static void LocalApplicationDataStelemI(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0.1f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 30f, 0f);
			A_0 = 324;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		public static void SodaAll()
		{
			int num = 247;
			int num2 = 247;
			num2 = 247;
			while (num2 != 0)
			{
				int num3;
				ScienceExperimentManager.PlayerGameState[] array;
				int num4;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,GorillaTag.ScienceExperimentManager/PlayerGameState[]&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 247;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00020B40 File Offset: 0x0001ED40
		private static void CollectFromServerContextSoapParameterAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 13 + 327;
			A_0 = num;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		private static void BrSIDispatchImplType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.2f";
			bool flag = Mods.DickIsTiny == 3;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 167;
			A_0 = num;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00020C48 File Offset: 0x0001EE48
		private static void UniversalTimeUmAlQuraCalendar(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 450;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00020C70 File Offset: 0x0001EE70
		private static void getSortIdArgumentNull(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 17;
			A_21 = flag;
			int num = ((!A_21) ? 1 : 0) * 1 + 195;
			A_0 = num;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00020CD4 File Offset: 0x0001EED4
		private static void getScheduledConcurrentStoreOperationSetCanonicalizationContext(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00020CEC File Offset: 0x0001EEEC
		private static void GetViewISerializationSurrogate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00020D1C File Offset: 0x0001EF1C
		private static void ReferenceIdentityDefinitionToText(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 2;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 364;
			A_0 = num;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00020D80 File Offset: 0x0001EF80
		private static void getDateEtwEnableCallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 10;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 181;
			A_0 = num;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		private static void MonthDefinitionAppIdApplication(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			Mods.pointer.transform.position = A_4.point;
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 351;
			A_0 = num;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00020E58 File Offset: 0x0001F058
		private static void IReferenceIdentitySupportUrl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_4)) ? 1 : 0) * 1 + 344;
			A_0 = num;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00020ED8 File Offset: 0x0001F0D8
		private static void InitializeLifetimeServiceremoveCancelKeyPress(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 126;
			A_0 = num;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00020F20 File Offset: 0x0001F120
		private static void MdSigCallingConventionNIname(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00020F38 File Offset: 0x0001F138
		private static void PrePrepareMethodAttributesetLevel(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance == A_4.distance;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 223;
			A_0 = num;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		public static void SideRoll()
		{
			int num = 313;
			int num2 = 313;
			num2 = 313;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 313;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00020FEC File Offset: 0x0001F1EC
		private static void FormatAssemblyAsDate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Slow";
			Mods.flySpeed = 5f;
			bool flag = Mods.TurnGay == 9;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 378;
			A_0 = num;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00021074 File Offset: 0x0001F274
		private static void AbbreviatedMonthNamesCommonNumberSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0002108C File Offset: 0x0001F28C
		private static void GetMachineStoreForAssemblyQuerySource(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_7 = array;
			A_7[0].color = Mods.FirstColor;
			A_7[0].time = 0f;
			A_7[1].color = Mods.FirstColor;
			A_7[1].time = 0.3f;
			A_7[2].color = Mods.SecondColor;
			A_7[2].time = 0.6f;
			A_7[3].color = Mods.SecondColor;
			A_7[3].time = 1f;
			ColorChanger colorChanger = Mods.pointer.AddComponent<ColorChanger>();
			A_8 = colorChanger;
			A_8.colors = new Gradient
			{
				colorKeys = A_7
			};
			A_8.Start();
			A_0 = 349;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000211F8 File Offset: 0x0001F3F8
		private static void ConfiguredTaskAwaitableSearchOption(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 61;
			A_0 = num;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00021264 File Offset: 0x0001F464
		public static void EnableInstantHandTaps()
		{
			int num = 260;
			int num2 = 260;
			num2 = 260;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 260;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000212A8 File Offset: 0x0001F4A8
		private static void ExternalThreadingTransparent(ref int A_0, ref int A_1, ref int A_2, ref MeshCollider[] A_3, ref int A_4, ref MeshCollider A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000212C0 File Offset: 0x0001F4C0
		private static void UseNonExportableKeySuppressChangeType(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			A_1 = 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000212D8 File Offset: 0x0001F4D8
		private static void ModuleGetDocument(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			VRRig vrrig = A_16.Current;
			A_17 = vrrig;
			bool flag = A_17 != GorillaTagger.Instance.offlineVRRig;
			A_18 = flag;
			int num = ((!A_18) ? 1 : 0) * 5 + 24;
			A_0 = num;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00021364 File Offset: 0x0001F564
		// Note: this type is marked as 'beforefieldinit'.
		static Mods()
		{
			Mods.ControlIsAppEarlierThanSilverlight();
			int num = 468;
			int num2 = 468;
			num2 = 468;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 468;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000213AC File Offset: 0x0001F5AC
		private static void GuidHours(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 9;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 378;
			A_0 = num;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00021410 File Offset: 0x0001F610
		private static void getNumberLockResourceSet(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			GameObject gameObject = GameObject.Find("Environment Objects/PersistentObjects_Prefab/GorillaUI");
			A_4 = gameObject;
			Transform transform = A_4.transform;
			A_5 = transform;
			int num = 0;
			A_6 = num;
			A_0 = 39;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00021478 File Offset: 0x0001F678
		private static void TraceLoggingDataCollectorIsNetFxLegacySecurityPolicy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0002149C File Offset: 0x0001F69C
		private static void MethodBodySmuggledMethodCallMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownL = WristMenu.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 3 + 392;
			A_0 = num;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000214F8 File Offset: 0x0001F6F8
		private static void GetSizeMaxgetIsSystem(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00021510 File Offset: 0x0001F710
		private static void GetParamDefPropsLocalServer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 115;
			A_0 = num;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00021558 File Offset: 0x0001F758
		private static void getEvidenceObjectAuthenticated(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = A_5 != GorillaTagger.Instance.offlineVRRig;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 112;
			A_0 = num;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000215E4 File Offset: 0x0001F7E4
		private static void VisibilityMaskPackageSimpleName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.headMesh.transform.position = GorillaTagger.Instance.offlineVRRig.rightHandTransform.position;
			A_1 = 0;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0002162C File Offset: 0x0001F82C
		private static void setHijriAdjustmentsetObjectMode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0002165C File Offset: 0x0001F85C
		private static void LockRegionNoRootDirectory(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Player.Instance.headCollider.transform.position = Player.Instance.rightControllerTransform.transform.position;
			A_1 = 0;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000216A0 File Offset: 0x0001F8A0
		private static void AbbreviatedMonthNamesTupleExtensions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Time.time > Mods.Deli;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 389;
			A_0 = num;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00021704 File Offset: 0x0001F904
		private static void RestSetApplicationRunningState(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 126;
			A_0 = num;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0002174C File Offset: 0x0001F94C
		private static void ResourceManagerNeutralResourcesNotFoundSetLocalSignature(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 6 + 333;
			A_0 = num;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000217D0 File Offset: 0x0001F9D0
		private static void FullSystemTimeCanBeCanceled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.fpcc = true;
			bool flag = GameObject.Find("Third Person Camera") != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 399;
			A_0 = num;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00021844 File Offset: 0x0001FA44
		private static void getIsSingleBytegetApplicationEvidence(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 61;
			A_0 = num;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0002188C File Offset: 0x0001FA8C
		private static void getUserMessageCryptoKeySecurity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_0 = 341;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000218E0 File Offset: 0x0001FAE0
		public static void RigGun()
		{
			int num = 80;
			int num2 = 80;
			num2 = 80;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				GameObject gameObject;
				bool flag2;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag3;
				GameObject gameObject2;
				GameObject gameObject3;
				bool flag4;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				bool flag5;
				GradientColorKey[] array3;
				ColorChanger colorChanger3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,UnityEngine.GameObject&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref gameObject, ref flag2, ref array, ref colorChanger, ref flag3, ref gameObject2, ref gameObject3, ref flag4, ref array2, ref colorChanger2, ref flag5, ref array3, ref colorChanger3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 80;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00021934 File Offset: 0x0001FB34
		private static void setFirstDayOfWeekCreateDomain(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			((IDisposable)A_8).Dispose();
			A_1 = 2;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0002195C File Offset: 0x0001FB5C
		public static void InvisiblePlatforms()
		{
			int num = 397;
			int num2 = 397;
			num2 = 397;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 397;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000219A0 File Offset: 0x0001FBA0
		private static void SizeArraySingleArrayTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 448;
			A_0 = num;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000219FC File Offset: 0x0001FBFC
		private static void BrowserBackaction(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			bool changingColors = Mods.ChangingColors;
			A_6 = changingColors;
			int num = ((!A_6) ? 1 : 0) * 1 + 347;
			A_0 = num;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00021AAC File Offset: 0x0001FCAC
		private static void MemberCountBinderState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.2f";
			bool flag = Mods.DickIsTiny == 9;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 179;
			A_0 = num;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00021B50 File Offset: 0x0001FD50
		private static void BinaryAssemblyInfoDefineNestedType(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.PlatformsThing(true, false);
			A_1 = 0;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00021B78 File Offset: 0x0001FD78
		public static void Platforms()
		{
			int num = 396;
			int num2 = 396;
			num2 = 396;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 396;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00021BBC File Offset: 0x0001FDBC
		private static void CountdownEventAppDomainTimerSafeHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("BeachBall").transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_1 = 0;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00021BFC File Offset: 0x0001FDFC
		public static void GhostMonke()
		{
			int num = 303;
			int num2 = 303;
			num2 = 303;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 303;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00021C40 File Offset: 0x0001FE40
		private static void StandardTaskContinuationgetIsThreadOwnerTrackingEnabled(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 270;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00021C7C File Offset: 0x0001FE7C
		private static void TypesIsMetric(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 4;
			A_2 = 117;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		public static void FixHandTaps()
		{
			int num = 262;
			int num2 = 262;
			num2 = 262;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 262;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		private static void AppDomainLevelActivatorFUNCVIRTUAL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			A_0 = 341;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00021CFC File Offset: 0x0001FEFC
		private static void getKeyPasswordgetValueCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_1 = 0;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00021D14 File Offset: 0x0001FF14
		private static void NoInlininggetUtc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * -45f;
			A_1 = 0;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00021D64 File Offset: 0x0001FF64
		private static void IdManagersetUIContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool enabled = GorillaTagger.Instance.offlineVRRig.enabled;
			A_4 = enabled;
			int num = ((!A_4) ? 1 : 0) * 1 + 309;
			A_0 = num;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00021DCC File Offset: 0x0001FFCC
		private static void getSetupInformationBigEndianUnicode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.3f";
			bool flag = Mods.DickIsTiny == 16;
			A_20 = flag;
			int num = ((!A_20) ? 1 : 0) * 1 + 193;
			A_0 = num;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00021E70 File Offset: 0x00020070
		private static void CharUnknownsetCalendarType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			Mods.pointer.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			bool flag = Mods.pointer != null;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 10 + 140;
			A_0 = num;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00021EF4 File Offset: 0x000200F4
		private static void FNonExtensiblePermissionRequestEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 304;
			A_0 = num;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00021F50 File Offset: 0x00020150
		private static void UTFEncodingSealedISecurityEncodable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.sizeScale = 0.05f;
			Player.Instance.scale = Mods.sizeScale;
			A_1 = 0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00021F84 File Offset: 0x00020184
		private static void MonthSpaceGetDecimal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_4 = triggerDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 209;
			A_0 = num;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00021FE0 File Offset: 0x000201E0
		private static void SetActorAsReferenceWhenCopyingClaimsIdentityBStrWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Fast";
			Mods.flySpeed = 25f;
			bool flag = Mods.TurnGay == 11;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 382;
			A_0 = num;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00022068 File Offset: 0x00020268
		private static void CurrentAssemblyCryptAcquireContextFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_5.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			A_5.transform.position = A_4.point;
			Object.Destroy(A_5.GetComponent<BoxCollider>());
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<Collider>());
			Object.Destroy(A_5, Time.deltaTime);
			bool triggerDownR = WristMenu.triggerDownR;
			A_9 = triggerDownR;
			int num = ((!A_9) ? 1 : 0) * 7 + 85;
			A_0 = num;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00022158 File Offset: 0x00020358
		private static void CommonDesktopDirectoryRetargetable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 443;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00022170 File Offset: 0x00020370
		private static void BindLockRegion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12, ref bool A_13, ref GradientColorKey[] A_14, ref ColorChanger A_15)
		{
			A_1 = 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00022188 File Offset: 0x00020388
		private static void IDLFLAGNONEEnabledForAnyListener(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000221A0 File Offset: 0x000203A0
		private static void ThreadPoolTaskSchedulerEnsureInitialized(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_3.distance < A_4.distance;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 4 + 218;
			A_0 = num;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0002220C File Offset: 0x0002040C
		public unsafe static void LockOnGun()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 118;
			int num4 = 118;
			num4 = 118;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 1)
					{
						num4 = 118;
						if ((int)array[4] != 1)
						{
							num5 = (int)array[6];
							num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 40 + num2);
							for (num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + (int)array[3] + 40 + num2) + 40 + num2); num7 != num6; num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num7 + 40 + num2))
							{
								num8 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num8 + 16 + num2);
									array[3] = num8;
									array[1] = 1;
									num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num8 + 16 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[0];
							num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[4] = 0;
							array2[2] = array;
							array2[0] = ex;
							array2[3] = num5;
							array2[1] = 2;
							array = array2;
							num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 118;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num15 * 56 + 32 + num2);
						num17 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num15 * 56 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num7 * 56 + 24 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num14 * 56 + 32 + num2);
						num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num14 * 56 + 16 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num7 * 56 + 24 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num15 * 48 + 24 + num2);
						num17 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num15 * 48 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num7 * 48 + 16 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9BB:
						if (array == null || (int)array[4] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + 40 + num2);
								}
								else
								{
									num10 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 40 + num2);
									goto IL_9BB;
								}
							}
							goto IL_B57;
						}
						int num19 = (int)array[3];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 8 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num15 * 48 + 24 + num2);
								num10 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num15 * 48 + 8 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num5 * 48 + 16 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num7 + 40 + num2);
								}
								else
								{
									num5 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 40 + num2);
									goto IL_9BB;
								}
							}
							break;
						}
						if ((int)array[3] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
					array2 = new object[8];
					array2[4] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[3] = num5;
					array2[1] = 1;
					array = array2;
					num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B57:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + 16 + num2);
					array2 = new object[8];
					array2[4] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[3] = num10;
					array2[1] = 1;
					array = array2;
					num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + 16 + num2);
				}
				num4 = 118;
				return;
				IL_1B2:
				if (num6 != -1)
				{
					goto IL_1BD;
				}
				goto IL_3E1;
				IL_1BD:
				num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + 24 + num2);
				if (2 == num7)
				{
					goto IL_1DC;
				}
				if (1 == num7)
				{
					goto IL_36E;
				}
				goto IL_3E1;
				IL_1DC:
				num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + 32 + num2);
				if (num9 == -1)
				{
					goto IL_22A;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_210;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_210:
				if (type.IsInstanceOfType(array2[0]))
				{
					goto IL_22A;
				}
				num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + 48 + num2);
				goto IL_1B2;
				IL_22A:
				num5 = num6;
				num8 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 40 + num2) + 40 + num2);
				num13 = (int)array2[5];
				IL_24E:
				if (num13 != num8)
				{
					goto IL_2CD;
				}
				int num22 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[4] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[3] = num5;
				array5[1] = 2;
				array = array5;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
				goto IL_1A;
				IL_2CD:
				num18 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num13 + 32 + num2);
				if (num18 == -1)
				{
					goto IL_35C;
				}
				num22 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 16 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[4] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[3] = num18;
				array5[6] = num5;
				array5[1] = 1;
				array = array5;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num18 + 16 + num2);
				goto IL_1A;
				IL_35C:
				num13 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num13 + 40 + num2);
				goto IL_24E;
				IL_36E:
				num22 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				array5 = new object[8];
				array5[4] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[5] = (int)array2[5];
				array5[3] = num6;
				array5[1] = 0;
				array = array5;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num6 + num2);
				goto IL_1A;
				IL_3E1:
				array = (object[])array[2];
				Exception ex3 = array2[0];
				int num23 = (int)array2[5];
				IL_400:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_40E:
				num14 = (num21 + num10) / 2;
				num15 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num14 * 56 + 32 + num2);
				num16 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num14 * 56 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_454;
				}
				if (num15 > num22)
				{
					goto IL_45C;
				}
				num8 = num14;
				num5 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 152 + num8 * 56 + 24 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_484;
				IL_454:
				num21 = num14 + 1;
				goto IL_40E;
				IL_45C:
				num10 = num14 - 1;
				goto IL_40E;
				IL_484:
				if (array != null)
				{
					goto IL_48F;
				}
				goto IL_61A;
				IL_48F:
				if ((int)array[4] != 1)
				{
					goto IL_54D;
				}
				int num24 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_4B3;
				}
				int num25 = -1;
				goto IL_534;
				IL_4B3:
				num17 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num9 + 8 + num2);
				num16 = 0;
				num15 = 2;
				IL_4C5:
				num14 = (num16 + num15) / 2;
				num10 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num14 * 48 + 24 + num2);
				num21 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num14 * 48 + 8 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_50A;
				}
				if (num10 > num17)
				{
					goto IL_512;
				}
				num5 = num14;
				num8 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num5 * 48 + 16 + num2);
				num25 = num8;
				goto IL_534;
				IL_50A:
				num16 = num14 + 1;
				goto IL_4C5;
				IL_512:
				num15 = num14 - 1;
				goto IL_4C5;
				IL_534:
				if (num24 != num25)
				{
					goto IL_53C;
				}
				goto IL_61A;
				IL_53C:
				array = (object[])array[2];
				goto IL_484;
				IL_54D:
				num18 = (int)array[1];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_56E;
				}
				if (num18 != 0)
				{
					goto IL_56D;
				}
				array2 = array;
				num6 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + (int)array2[3] + 48 + num2);
				goto IL_1B2;
				IL_56D:
				IL_56E:
				int num26 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_583;
				}
				int num27 = -1;
				goto IL_604;
				IL_583:
				num22 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num9 + 8 + num2);
				num21 = 0;
				num10 = 2;
				IL_595:
				num14 = (num21 + num10) / 2;
				num15 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num14 * 48 + 24 + num2);
				num16 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num14 * 48 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5DA;
				}
				if (num15 > num22)
				{
					goto IL_5E2;
				}
				num8 = num14;
				num5 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + 320 + num8 * 48 + 16 + num2);
				num27 = num5;
				goto IL_604;
				IL_5DA:
				num21 = num14 + 1;
				goto IL_595;
				IL_5E2:
				num10 = num14 - 1;
				goto IL_595;
				IL_604:
				if (num26 != num27)
				{
					goto IL_609;
				}
				goto IL_61A;
				IL_609:
				array = (object[])array[2];
				goto IL_484;
				IL_61A:
				if (-1 != num9)
				{
					goto IL_626;
				}
				int num28 = 1;
				throw ex3;
				IL_626:
				num7 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num9 + 24 + num2);
				num10 = num7;
				IL_637:
				if (num10 != -1)
				{
					goto IL_64E;
				}
				num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num9 + 40 + num2);
				goto IL_484;
				IL_64E:
				num15 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + 24 + num2);
				if (2 == num15)
				{
					goto IL_679;
				}
				if (1 == num15)
				{
					goto IL_7E7;
				}
				num9 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num9 + 40 + num2);
				goto IL_484;
				IL_679:
				num14 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + 32 + num2);
				if (num14 == -1)
				{
					goto IL_6C8;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6AD;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6AD:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6C8;
				}
				num10 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + 48 + num2);
				goto IL_637;
				IL_6C8:
				num5 = num10;
				num8 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 40 + num2) + 40 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6F1:
				if (num17 != num8)
				{
					goto IL_75A;
				}
				num21 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[4] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[3] = num5;
				array2[1] = 2;
				array = array2;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num5 + 16 + num2);
				goto IL_1A;
				IL_75A:
				num16 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num17 + 32 + num2);
				if (num16 == -1)
				{
					goto IL_7D5;
				}
				num21 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num16 + 16 + num2);
				array2 = new object[8];
				array2[4] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[3] = num16;
				array2[6] = num5;
				array2[1] = 1;
				array = array2;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num16 + 16 + num2);
				goto IL_1A;
				IL_7D5:
				num17 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num17 + 40 + num2);
				goto IL_6F1;
				IL_7E7:
				num21 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[4] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[5] = num13;
				array2[3] = num10;
				array2[1] = 0;
				array = array2;
				num3 = *(ref LegacyEvidenceWrapperReadWrite.getTypeIdLocalBuilder + num10 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_400;
				}
				throw ex4;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00022E28 File Offset: 0x00021028
		public static void Jump()
		{
			int num = 199;
			int num2 = 199;
			num2 = 199;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 199;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00022E70 File Offset: 0x00021070
		private static void UCOMIEnumConnectionPointsgetTimeOfDay(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00022E88 File Offset: 0x00021088
		private static void InsertRangeGlobalResourceContextBestFitCultureInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -4 + 61;
			A_0 = num;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00022ED0 File Offset: 0x000210D0
		private static void LocalFindAndPopTimeZoneNotFoundException(ref int A_0, ref int A_1, ref int A_2, ref VRRig[] A_3, ref int A_4, ref VRRig A_5)
		{
			VRRig vrrig = A_3[A_4];
			A_5 = vrrig;
			A_5.mainSkin.material.color = Color.black;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 292;
			A_0 = num2;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00022F70 File Offset: 0x00021170
		private static void RequireFullexceptionQ(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			A_3[A_4].touchedLiquid = true;
			A_3[A_4].playerId = ((PhotonNetwork.PlayerList[A_4] == null) ? 0 : PhotonNetwork.PlayerList[A_4].ActorNumber);
			int num = A_4 + 1;
			A_4 = num;
			bool flag = A_4 < 10;
			A_5 = flag;
			int num2 = (A_5 ? 1 : 0) * -2 + 250;
			A_0 = num2;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00023068 File Offset: 0x00021268
		private static void AddAuditgetIsRetval(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_right_false ? 1 : 0) * 1 + 440;
			A_0 = num;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000230AC File Offset: 0x000212AC
		private static void NternalComImportAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000230C4 File Offset: 0x000212C4
		private static void NewPermissionElementEventProviderWriter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			Object.Destroy(A_10, Time.deltaTime);
			Object.Destroy(A_11, Time.deltaTime);
			A_0 = 93;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00023104 File Offset: 0x00021304
		private static void MethodNamegetChannelScheme(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 277;
			A_0 = num;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0002314C File Offset: 0x0002134C
		public static void GrabBug()
		{
			int num = 254;
			int num2 = 254;
			num2 = 254;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 254;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00023190 File Offset: 0x00021390
		private static void DebuggerBrowsableAttributeStreamTokenReader(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			bool flag = A_20 < A_21;
			A_22 = flag;
			int num = ((!A_22) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00023200 File Offset: 0x00021400
		public static void FlushRemoteProceduralCalls()
		{
			int num = 6;
			int num2 = 6;
			num2 = 6;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaiseEventOptions raiseEventOptions;
				RaiseEventOptions raiseEventOptions2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,Photon.Realtime.RaiseEventOptions&), ref num, ref num2, ref num3, ref flag, ref raiseEventOptions, ref raiseEventOptions2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 6;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00023238 File Offset: 0x00021438
		private static void CurrentEraIEnumerator(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 31;
			A_0 = num;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00023280 File Offset: 0x00021480
		private static void SystemThreadingTasksFutureDebugViewSetMessageCtrl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			bool flag = Mods.pointer == null;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 4 + 346;
			A_0 = num;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000232E8 File Offset: 0x000214E8
		private static void ProgIdRedirectionEntryFieldIdNN(ref int A_0, ref int A_1, ref int A_2, ref GradientColorKey[] A_3, ref Gradient A_4, ref float A_5, ref Color A_6, ref bool A_7, ref bool A_8)
		{
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				A_6.r,
				A_6.g,
				A_6.b,
				true
			});
			Mods.FlushRemoteProceduralCalls();
			A_1 = 0;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0002338C File Offset: 0x0002158C
		private static void ExportAsBitT(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			Traverse.Create(ScienceExperimentManager.instance).Field("inGamePlayerCount").SetValue(10);
			ScienceExperimentManager.PlayerGameState[] array = new ScienceExperimentManager.PlayerGameState[10];
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 249;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000233FC File Offset: 0x000215FC
		public static void PlaceHolder()
		{
			int num = 243;
			int num2 = 243;
			num2 = 243;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 243;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00023440 File Offset: 0x00021640
		private static void MakeGenericMethodCreateProxy(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool leftGrab = ControllerInputPoller.instance.leftGrab;
			A_11 = leftGrab;
			int num = ((!A_11) ? 1 : 0) * 8 + 227;
			A_0 = num;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000234A4 File Offset: 0x000216A4
		public static void nuhuhheadspin()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 1;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000234D8 File Offset: 0x000216D8
		public static void NightTime()
		{
			int num = 265;
			int num2 = 265;
			num2 = 265;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 265;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0002351C File Offset: 0x0002171C
		private static void getLocalForegroundMask(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.sizeScale += 0.05f;
			bool triggerDownL = WristMenu.triggerDownL;
			A_5 = triggerDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 211;
			A_0 = num;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0002358C File Offset: 0x0002178C
		private static void OrderablePartitionerDynamicPartitionerForIndexRangeAbstract(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 52;
			A_0 = num;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000235D4 File Offset: 0x000217D4
		public static void Launch()
		{
			int num = 326;
			int num2 = 326;
			num2 = 326;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				GradientColorKey[] array;
				ColorChanger colorChanger;
				bool flag4;
				bool flag5;
				bool flag6;
				GradientColorKey[] array2;
				ColorChanger colorChanger2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&,System.Boolean&,System.Boolean&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref array, ref colorChanger, ref flag4, ref flag5, ref flag6, ref array2, ref colorChanger2, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 326;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0002362C File Offset: 0x0002182C
		private static void RemoveInheritedAcesGuidResult(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			int num = A_10 + 1;
			A_10 = num;
			bool flag = A_10 < A_7.childCount;
			A_23 = flag;
			int num2 = (A_23 ? 1 : 0) * -18 + 37;
			A_0 = num2;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000236BC File Offset: 0x000218BC
		private static void TYPEFLAGFCANCREATELeftAltPressed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1.3f";
			bool flag = Mods.DickIsTiny == 10;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 181;
			A_0 = num;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00023760 File Offset: 0x00021960
		private static void DarkCyanGetUninitializedObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 1;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 362;
			A_0 = num;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000237C4 File Offset: 0x000219C4
		private static void getIsBackgroundCodeBase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			A_3 = rightControllerPrimaryButton;
			int num = ((!A_3) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00023828 File Offset: 0x00021A28
		private static void ContextInArrayTypeSpec(ref int A_0, ref int A_1, ref int A_2)
		{
			BetterDayNightManager.instance.SetTimeOfDay(0);
			A_1 = 0;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00023854 File Offset: 0x00021A54
		private static void HeadersEndModifyAuditRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_5 = triggerDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 211;
			A_0 = num;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000238B0 File Offset: 0x00021AB0
		public static void WaterSplashHands()
		{
			int num = 387;
			int num2 = 387;
			num2 = 387;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 387;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000238FC File Offset: 0x00021AFC
		private static void SetHandledCalculateDelimiterOfDeploymentsBasedOnQuota(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			Vector3 vector = A_4.point - Player.Instance.leftControllerTransform.position;
			A_8 = vector;
			Vector3 normalized = A_8.normalized;
			A_14 = normalized;
			Physics.gravity = A_14 * 9.81f;
			A_0 = 231;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00023978 File Offset: 0x00021B78
		private static void HashElementTransformGetTypeComp(ref int A_0, ref int A_1, ref int A_2, ref RaycastHit A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref Vector3 A_14, ref bool A_15)
		{
			bool flag = A_4.distance < 1f;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 229;
			A_0 = num;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000239E0 File Offset: 0x00021BE0
		private static void TYPEFLAGFREVERSEBINDbodyWithState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00023A04 File Offset: 0x00021C04
		private static void PermissionSetTripleRuntimeFieldInfo(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 360), (float)Random.Range(0, 360));
			GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new Vector3((float)Random.Range(0, 360), (float)Random.Range(0, 180), (float)Random.Range(0, 180));
			A_1 = 0;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00023BF8 File Offset: 0x00021DF8
		private static void SystemThreadingTasksTaskSchedulerDebugViewsetCalendarType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
			WristMenu.settingsbuttons[6].buttonText = "ArmSize: 1f";
			bool flag = Mods.DickIsTiny == 13;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 1 + 187;
			A_0 = num;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00023C9C File Offset: 0x00021E9C
		private static void FNonExtensibleGetStore(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			bool flag = Mods.TurnGay == 4;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 368;
			A_0 = num;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00023D00 File Offset: 0x00021F00
		private static void AutoShr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_7 = array;
			A_7[0].color = Mods.FirstColor;
			A_7[0].time = 0f;
			A_7[1].color = Mods.FirstColor;
			A_7[1].time = 0.3f;
			A_7[2].color = Mods.SecondColor;
			A_7[2].time = 0.6f;
			A_7[3].color = Mods.SecondColor;
			A_7[3].time = 1f;
			ColorChanger colorChanger = A_5.AddComponent<ColorChanger>();
			A_8 = colorChanger;
			A_8.colors = new Gradient
			{
				colorKeys = A_7
			};
			A_8.Start();
			A_0 = 84;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00023E70 File Offset: 0x00022070
		private static void fVersionedProduct(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(0f, 0f, 0f);
			A_1 = 0;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00023EAC File Offset: 0x000220AC
		public Mods()
		{
			int num = 467;
			int num2 = 467;
			num2 = 467;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.Mods), ref num, ref num2, ref num3, this, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 467;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00023EF0 File Offset: 0x000220F0
		private static void SetCheckSumHasCurrent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0f, 0.07f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 0f, 8f);
			GorillaTagger.Instance.offlineVRRig.GetComponent<Collider>().enabled = true;
			A_0 = 318;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00023F90 File Offset: 0x00022190
		private static void EntryContextMarshalException(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
			A_1 = 0;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00023FC8 File Offset: 0x000221C8
		public static void FlySpeedTest(bool Main)
		{
			int num = 355;
			int num2 = 355;
			num2 = 355;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				bool flag13;
				bool flag14;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, ref flag13, ref flag14, ref flag15, Main, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 355;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0002402C File Offset: 0x0002222C
		private static void getArgumentTypeAppendFormat(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref GradientColorKey[] A_6, ref ColorChanger A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref GradientColorKey[] A_11, ref ColorChanger A_12)
		{
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
			A_0 = 341;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00024080 File Offset: 0x00022280
		private static void WSetFault(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 297;
			A_0 = num;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000240DC File Offset: 0x000222DC
		private static void IntPtrTypeEmptyStruct(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_1 = 4;
			A_2 = 54;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00024100 File Offset: 0x00022300
		private static void PassesActivityFilterIMPFASTFLOW(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Fast";
			Mods.flySpeed = 25f;
			bool flag = Mods.TurnGay == 3;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 366;
			A_0 = num;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00024188 File Offset: 0x00022388
		public unsafe static void MakePlayersHaveNoName()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 280;
			int num4 = 280;
			num4 = 280;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 280;
						if ((int)array[4] != 1)
						{
							num5 = (int)array[0];
							num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 40 + num2);
							for (num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + (int)array[5] + 40 + num2) + 32 + num2); num7 != num6; num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num7 + 32 + num2))
							{
								num8 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num7 + 48 + num2);
								if (num8 != -1)
								{
									num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num8 + 16 + num2);
									array[5] = num8;
									array[1] = 1;
									num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num8 + 16 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[2];
							num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
							ex2 = ex;
							array = (object[])array[3];
							array2 = new object[8];
							array2[4] = 0;
							array2[3] = array;
							array2[2] = ex;
							array2[5] = num5;
							array2[1] = 2;
							array = array2;
							num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
							continue;
						}
						num10 = (int)array[6];
						array = (object[])array[3];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 6)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 280;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num15 * 64 + 32 + num2);
						num17 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num15 * 64 + 24 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num7 * 64 + 40 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num14 * 64 + 32 + num2);
						num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num14 * 64 + 24 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num7 * 64 + 40 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num15 * 56 + 24 + num2);
						num17 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num15 * 56 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num7 * 56 + 40 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9DA:
						if (array == null || (int)array[4] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 32 + num2);
								}
								else
								{
									num10 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 48 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 32 + num2);
									goto IL_9DA;
								}
							}
							goto IL_B78;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 16 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num15 * 56 + 24 + num2);
								num10 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num15 * 56 + 16 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num5 * 56 + 40 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num7 + 32 + num2);
								}
								else
								{
									num5 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 48 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 32 + num2);
									goto IL_9DA;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[3];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
					array2 = new object[8];
					array2[4] = 1;
					array2[3] = array;
					array2[6] = num11;
					array2[5] = num5;
					array2[1] = 1;
					array = array2;
					num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B78:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 16 + num2);
					array2 = new object[8];
					array2[4] = 1;
					array2[3] = array;
					array2[6] = num11;
					array2[5] = num10;
					array2[1] = 1;
					array = array2;
					num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 16 + num2);
				}
				num4 = 280;
				return;
				IL_1C4:
				if (num6 != -1)
				{
					goto IL_1CF;
				}
				goto IL_3F7;
				IL_1CF:
				num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 24 + num2);
				if (2 == num7)
				{
					goto IL_1EE;
				}
				if (1 == num7)
				{
					goto IL_380;
				}
				goto IL_3F7;
				IL_1EE:
				num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 48 + num2);
				if (num9 == -1)
				{
					goto IL_23C;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_222;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_222:
				if (type.IsInstanceOfType(array2[2]))
				{
					goto IL_23C;
				}
				num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 72 + num2);
				goto IL_1C4;
				IL_23C:
				num5 = num6;
				num8 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 40 + num2) + 32 + num2);
				num13 = (int)array2[7];
				IL_260:
				if (num13 != num8)
				{
					goto IL_2DF;
				}
				int num22 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
				ex2 = array2[2];
				array = (object[])array[3];
				object[] array5 = new object[8];
				array5[4] = 0;
				array5[3] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[5] = num5;
				array5[1] = 2;
				array = array5;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
				goto IL_23;
				IL_2DF:
				num18 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num13 + 48 + num2);
				if (num18 == -1)
				{
					goto IL_36E;
				}
				num22 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 16 + num2);
				array = (object[])array[3];
				array5 = new object[8];
				array5[4] = 0;
				array5[3] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[5] = num18;
				array5[0] = num5;
				array5[1] = 1;
				array = array5;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num18 + 16 + num2);
				goto IL_23;
				IL_36E:
				num13 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num13 + 32 + num2);
				goto IL_260;
				IL_380:
				num22 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 8 + num2);
				ex2 = array2[2];
				array = (object[])array[3];
				array5 = new object[8];
				array5[4] = 0;
				array5[3] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[5] = num6;
				array5[1] = 0;
				array = array5;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num6 + 8 + num2);
				goto IL_23;
				IL_3F7:
				array = (object[])array[3];
				Exception ex3 = array2[2];
				int num23 = (int)array2[7];
				IL_416:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_424:
				num14 = (num21 + num10) / 2;
				num15 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num14 * 64 + 32 + num2);
				num16 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num14 * 64 + 24 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_46A;
				}
				if (num15 > num22)
				{
					goto IL_472;
				}
				num8 = num14;
				num5 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 152 + num8 * 64 + 40 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_49A;
				IL_46A:
				num21 = num14 + 1;
				goto IL_424;
				IL_472:
				num10 = num14 - 1;
				goto IL_424;
				IL_49A:
				if (array != null)
				{
					goto IL_4A5;
				}
				goto IL_634;
				IL_4A5:
				if ((int)array[4] != 1)
				{
					goto IL_565;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4C9;
				}
				int num25 = -1;
				goto IL_54C;
				IL_4C9:
				num17 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num9 + 16 + num2);
				num16 = 0;
				num15 = 2;
				IL_4DC:
				num14 = (num16 + num15) / 2;
				num10 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num14 * 56 + 24 + num2);
				num21 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num14 * 56 + 16 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_522;
				}
				if (num10 > num17)
				{
					goto IL_52A;
				}
				num5 = num14;
				num8 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num5 * 56 + 40 + num2);
				num25 = num8;
				goto IL_54C;
				IL_522:
				num16 = num14 + 1;
				goto IL_4DC;
				IL_52A:
				num15 = num14 - 1;
				goto IL_4DC;
				IL_54C:
				if (num24 != num25)
				{
					goto IL_554;
				}
				goto IL_634;
				IL_554:
				array = (object[])array[3];
				goto IL_49A;
				IL_565:
				num18 = (int)array[1];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_586;
				}
				if (num18 != 0)
				{
					goto IL_585;
				}
				array2 = array;
				num6 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + (int)array2[5] + 72 + num2);
				goto IL_1C4;
				IL_585:
				IL_586:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_59B;
				}
				int num27 = -1;
				goto IL_61E;
				IL_59B:
				num22 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num9 + 16 + num2);
				num21 = 0;
				num10 = 2;
				IL_5AE:
				num14 = (num21 + num10) / 2;
				num15 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num14 * 56 + 24 + num2);
				num16 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num14 * 56 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5F4;
				}
				if (num15 > num22)
				{
					goto IL_5FC;
				}
				num8 = num14;
				num5 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + 344 + num8 * 56 + 40 + num2);
				num27 = num5;
				goto IL_61E;
				IL_5F4:
				num21 = num14 + 1;
				goto IL_5AE;
				IL_5FC:
				num10 = num14 - 1;
				goto IL_5AE;
				IL_61E:
				if (num26 != num27)
				{
					goto IL_623;
				}
				goto IL_634;
				IL_623:
				array = (object[])array[3];
				goto IL_49A;
				IL_634:
				if (-1 != num9)
				{
					goto IL_640;
				}
				int num28 = 1;
				throw ex3;
				IL_640:
				num7 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num9 + 24 + num2);
				num10 = num7;
				IL_651:
				if (num10 != -1)
				{
					goto IL_668;
				}
				num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num9 + 32 + num2);
				goto IL_49A;
				IL_668:
				num15 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 24 + num2);
				if (2 == num15)
				{
					goto IL_693;
				}
				if (1 == num15)
				{
					goto IL_801;
				}
				num9 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num9 + 32 + num2);
				goto IL_49A;
				IL_693:
				num14 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 48 + num2);
				if (num14 == -1)
				{
					goto IL_6E2;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6C7;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6C7:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E2;
				}
				num10 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 72 + num2);
				goto IL_651;
				IL_6E2:
				num5 = num10;
				num8 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 40 + num2) + 32 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_70B:
				if (num17 != num8)
				{
					goto IL_774;
				}
				num21 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[4] = 0;
				array2[3] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[5] = num5;
				array2[1] = 2;
				array = array2;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num5 + 16 + num2);
				goto IL_23;
				IL_774:
				num16 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num17 + 48 + num2);
				if (num16 == -1)
				{
					goto IL_7EF;
				}
				num21 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num16 + 16 + num2);
				array2 = new object[8];
				array2[4] = 0;
				array2[3] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[5] = num16;
				array2[0] = num5;
				array2[1] = 1;
				array = array2;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num16 + 16 + num2);
				goto IL_23;
				IL_7EF:
				num17 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num17 + 32 + num2);
				goto IL_70B;
				IL_801:
				num21 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 8 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[4] = 0;
				array2[3] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[5] = num10;
				array2[1] = 0;
				array = array2;
				num3 = *(ref ContractClassAttributeNoBuffering.ContentTypeStringToHGlobalAnsi + num10 + 8 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_416;
				}
				throw ex4;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00024DC8 File Offset: 0x00022FC8
		public static void DisableMyMovement()
		{
			int num = 325;
			int num2 = 325;
			num2 = 325;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 325;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00024E0C File Offset: 0x0002300C
		private static void FirstMatchCodeGroupIContextAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < Mods.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 465;
			A_0 = num2;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00024EAC File Offset: 0x000230AC
		private static void UnsafePackCharUnknownHigh(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00024EC4 File Offset: 0x000230C4
		private static void getEndInvokeCalledConvertTimeFromUtc(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string[] array = File.ReadAllLines("TemplatePrefs\\templateSavedPrefs.txt");
			A_4 = array;
			string[] array2 = A_4;
			A_5 = array2;
			int num = 0;
			A_6 = num;
			A_0 = 425;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00024F28 File Offset: 0x00023128
		private static void getAppendCommonProgramFiles(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaiseEventOptions A_4, ref RaiseEventOptions A_5)
		{
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions();
			A_4 = raiseEventOptions;
			A_4.CachingOption = 6;
			A_4.TargetActors = new int[]
			{
				PhotonNetwork.LocalPlayer.ActorNumber
			};
			RaiseEventOptions raiseEventOptions2 = A_4;
			A_5 = raiseEventOptions2;
			PhotonNetwork.NetworkingClient.OpRaiseEvent(200, null, A_5, SendOptions.SendReliable);
			A_0 = 9;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00024FCC File Offset: 0x000231CC
		public static void fpcoff()
		{
			int num = 403;
			int num2 = 403;
			num2 = 403;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 403;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00025010 File Offset: 0x00023210
		private static void TokenRestrictedDeviceClaimAttributesLocal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaiseEventOptions A_4, ref RaiseEventOptions A_5)
		{
			GorillaNot.instance.rpcErrorMax = int.MaxValue;
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			GorillaNot.instance.logErrorMax = int.MaxValue;
			PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
			PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig);
			PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
			PhotonNetwork.RemoveRPCsInGroup(int.MaxValue);
			PhotonNetwork.SendAllOutgoingCommands();
			GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
			A_1 = 0;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000250B4 File Offset: 0x000232B4
		private static void INVOCATIONFLAGSISCTORAsUi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Fast";
			Mods.flySpeed = 25f;
			bool flag = Mods.TurnGay == 7;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 374;
			A_0 = num;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0002513C File Offset: 0x0002333C
		private static void BraceFormatGetEnvoySink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.fpcc = false;
			bool flag = Mods.funn != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 404;
			A_0 = num;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000251A8 File Offset: 0x000233A8
		private static void setReflectionEmitGetValueKind(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 56;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000251E4 File Offset: 0x000233E4
		private static void IBindableIteratorGetFuncDesc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 436;
			A_0 = num;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00025260 File Offset: 0x00023460
		private static void IsComObjectCacheType(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -5 + 106;
			A_0 = num;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000252A8 File Offset: 0x000234A8
		private static void ParallelLoopBeginUIntArrayTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref GameObject A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9, ref GameObject A_10, ref GameObject A_11, ref bool A_12, ref GradientColorKey[] A_13, ref ColorChanger A_14, ref bool A_15, ref GradientColorKey[] A_16, ref ColorChanger A_17)
		{
			A_11.GetComponent<Renderer>().material.color = Color.black;
			Object.Destroy(A_10, Time.deltaTime);
			Object.Destroy(A_11, Time.deltaTime);
			A_0 = 93;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00025308 File Offset: 0x00023508
		private static void GetFilterStoreSubcategoryEnumeration(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00025320 File Offset: 0x00023520
		private static void RegionInfoCommonPrograms(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 119;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0002535C File Offset: 0x0002355C
		private static void ThreadTransferReceiveHandledObjgetKeyFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, bool A_18)
		{
			WristMenu.settingsbuttons[5].buttonText = "Fly Speed: Normal";
			Mods.flySpeed = 15f;
			bool flag = Mods.TurnGay == 6;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 372;
			A_0 = num;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000253E4 File Offset: 0x000235E4
		public unsafe static void Tracers()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 64;
			int num4 = 64;
			num4 = 64;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 64;
						if ((int)array[3] != 0)
						{
							num5 = (int)array[1];
							num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 32 + num2);
							for (num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + (int)array[5] + 32 + num2) + 24 + num2); num7 != num6; num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num7 + 24 + num2))
							{
								num8 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num7 + 40 + num2);
								if (num8 != -1)
								{
									num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num8 + 24 + num2);
									array[5] = num8;
									array[4] = 1;
									num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num8 + 24 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[7];
							num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[3] = 1;
							array2[2] = array;
							array2[7] = ex;
							array2[5] = num5;
							array2[4] = 2;
							array = array2;
							num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
							continue;
						}
						num10 = (int)array[0];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 3)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							GameObject gameObject;
							LineRenderer lineRenderer;
							bool flag2;
							GradientColorKey[] array3;
							ColorChanger colorChanger;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.LineRenderer&,System.Boolean&,UnityEngine.GradientColorKey[]&,ShibaGTTemplate.Utilities.ColorChanger&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, ref gameObject, ref lineRenderer, ref flag2, ref array3, ref colorChanger, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 64;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num15 * 64 + 24 + num2);
						num17 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num15 * 64 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num7 * 64 + 40 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num14 * 64 + 24 + num2);
						num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num14 * 64 + 16 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num7 * 64 + 40 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num15 * 56 + 24 + num2);
						num17 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num15 * 56 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num7 * 56 + 40 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D3:
						if (array == null || (int)array[3] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 24 + num2);
								}
								else
								{
									num10 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 40 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 24 + num2);
									goto IL_9D3;
								}
							}
							goto IL_B70;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 32 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num15 * 56 + 24 + num2);
								num10 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num15 * 56 + 8 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num5 * 56 + 40 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num7 + 24 + num2);
								}
								else
								{
									num5 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 40 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 24 + num2);
									goto IL_9D3;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[0] = num11;
					array2[5] = num5;
					array2[4] = 1;
					array = array2;
					num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B70:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 24 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[2] = array;
					array2[0] = num11;
					array2[5] = num10;
					array2[4] = 1;
					array = array2;
					num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 24 + num2);
				}
				num4 = 64;
				return;
				IL_1BC:
				if (num6 != -1)
				{
					goto IL_1C7;
				}
				goto IL_3F1;
				IL_1C7:
				num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 16 + num2);
				if (2 == num7)
				{
					goto IL_1E6;
				}
				if (1 == num7)
				{
					goto IL_378;
				}
				goto IL_3F1;
				IL_1E6:
				num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 48 + num2);
				if (num9 == -1)
				{
					goto IL_234;
				}
				Type[] array4;
				Type type;
				if ((type = array4[num9]) != null)
				{
					goto IL_21A;
				}
				RuntimeTypeHandle[] array5;
				array4[num9] = Type.GetTypeFromHandle(array5[num9]);
				type = array4[num9];
				IL_21A:
				if (type.IsInstanceOfType(array2[7]))
				{
					goto IL_234;
				}
				num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 56 + num2);
				goto IL_1BC;
				IL_234:
				num5 = num6;
				num8 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 32 + num2) + 24 + num2);
				num13 = (int)array2[6];
				IL_258:
				if (num13 != num8)
				{
					goto IL_2D7;
				}
				int num22 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
				ex2 = array2[7];
				array = (object[])array[2];
				object[] array6 = new object[8];
				array6[3] = 1;
				array6[2] = array;
				array6[7] = array2[7];
				array6[6] = (int)array2[6];
				array6[5] = num5;
				array6[4] = 2;
				array = array6;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
				goto IL_1A;
				IL_2D7:
				num18 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num13 + 40 + num2);
				if (num18 == -1)
				{
					goto IL_366;
				}
				num22 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 24 + num2);
				array = (object[])array[2];
				array6 = new object[8];
				array6[3] = 1;
				array6[2] = array;
				array6[7] = array2[7];
				array6[6] = (int)array2[6];
				array6[5] = num18;
				array6[1] = num5;
				array6[4] = 1;
				array = array6;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num18 + 24 + num2);
				goto IL_1A;
				IL_366:
				num13 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num13 + 24 + num2);
				goto IL_258;
				IL_378:
				num22 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 64 + num2);
				ex2 = array2[7];
				array = (object[])array[2];
				array6 = new object[8];
				array6[3] = 1;
				array6[2] = array;
				array6[7] = array2[7];
				array6[6] = (int)array2[6];
				array6[5] = num6;
				array6[4] = 0;
				array = array6;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num6 + 64 + num2);
				goto IL_1A;
				IL_3F1:
				array = (object[])array[2];
				Exception ex3 = array2[7];
				int num23 = (int)array2[6];
				IL_410:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_41E:
				num14 = (num21 + num10) / 2;
				num15 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num14 * 64 + 24 + num2);
				num16 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num14 * 64 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_464;
				}
				if (num15 > num22)
				{
					goto IL_46C;
				}
				num8 = num14;
				num5 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 136 + num8 * 64 + 40 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_494;
				IL_464:
				num21 = num14 + 1;
				goto IL_41E;
				IL_46C:
				num10 = num14 - 1;
				goto IL_41E;
				IL_494:
				if (array != null)
				{
					goto IL_49F;
				}
				goto IL_62C;
				IL_49F:
				if ((int)array[3] != 0)
				{
					goto IL_55E;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4C3;
				}
				int num25 = -1;
				goto IL_545;
				IL_4C3:
				num17 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num9 + 32 + num2);
				num16 = 0;
				num15 = 2;
				IL_4D6:
				num14 = (num16 + num15) / 2;
				num10 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num14 * 56 + 24 + num2);
				num21 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num14 * 56 + 8 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_51B;
				}
				if (num10 > num17)
				{
					goto IL_523;
				}
				num5 = num14;
				num8 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num5 * 56 + 40 + num2);
				num25 = num8;
				goto IL_545;
				IL_51B:
				num16 = num14 + 1;
				goto IL_4D6;
				IL_523:
				num15 = num14 - 1;
				goto IL_4D6;
				IL_545:
				if (num24 != num25)
				{
					goto IL_54D;
				}
				goto IL_62C;
				IL_54D:
				array = (object[])array[2];
				goto IL_494;
				IL_55E:
				num18 = (int)array[4];
				if (num18 == 2 || num18 == 1)
				{
					goto IL_57F;
				}
				if (num18 != 0)
				{
					goto IL_57E;
				}
				array2 = array;
				num6 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + (int)array2[5] + 56 + num2);
				goto IL_1BC;
				IL_57E:
				IL_57F:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_594;
				}
				int num27 = -1;
				goto IL_616;
				IL_594:
				num22 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num9 + 32 + num2);
				num21 = 0;
				num10 = 2;
				IL_5A7:
				num14 = (num21 + num10) / 2;
				num15 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num14 * 56 + 24 + num2);
				num16 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num14 * 56 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5EC;
				}
				if (num15 > num22)
				{
					goto IL_5F4;
				}
				num8 = num14;
				num5 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + 328 + num8 * 56 + 40 + num2);
				num27 = num5;
				goto IL_616;
				IL_5EC:
				num21 = num14 + 1;
				goto IL_5A7;
				IL_5F4:
				num10 = num14 - 1;
				goto IL_5A7;
				IL_616:
				if (num26 != num27)
				{
					goto IL_61B;
				}
				goto IL_62C;
				IL_61B:
				array = (object[])array[2];
				goto IL_494;
				IL_62C:
				if (-1 != num9)
				{
					goto IL_638;
				}
				int num28 = 1;
				throw ex3;
				IL_638:
				num7 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num9 + 16 + num2);
				num10 = num7;
				IL_649:
				if (num10 != -1)
				{
					goto IL_660;
				}
				num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num9 + 24 + num2);
				goto IL_494;
				IL_660:
				num15 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 16 + num2);
				if (2 == num15)
				{
					goto IL_68B;
				}
				if (1 == num15)
				{
					goto IL_7F9;
				}
				num9 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num9 + 24 + num2);
				goto IL_494;
				IL_68B:
				num14 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 48 + num2);
				if (num14 == -1)
				{
					goto IL_6DA;
				}
				Type type2;
				if ((type2 = array4[num14]) != null)
				{
					goto IL_6BF;
				}
				array4[num14] = Type.GetTypeFromHandle(array5[num14]);
				type2 = array4[num14];
				IL_6BF:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6DA;
				}
				num10 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 56 + num2);
				goto IL_649;
				IL_6DA:
				num5 = num10;
				num8 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 32 + num2) + 24 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_703:
				if (num17 != num8)
				{
					goto IL_76C;
				}
				num21 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[7] = ex3;
				array2[6] = num13;
				array2[5] = num5;
				array2[4] = 2;
				array = array2;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num5 + 24 + num2);
				goto IL_1A;
				IL_76C:
				num16 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num17 + 40 + num2);
				if (num16 == -1)
				{
					goto IL_7E7;
				}
				num21 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num16 + 24 + num2);
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[7] = ex3;
				array2[6] = num13;
				array2[5] = num16;
				array2[1] = num5;
				array2[4] = 1;
				array = array2;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num16 + 24 + num2);
				goto IL_1A;
				IL_7E7:
				num17 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num17 + 24 + num2);
				goto IL_703;
				IL_7F9:
				num21 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 64 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[2] = array;
				array2[7] = ex3;
				array2[6] = num13;
				array2[5] = num10;
				array2[4] = 0;
				array = array2;
				num3 = *(ref ArgumentInvalidOffLengetAllInternalsVisible.setSoapOptionsFlushAsync + num10 + 64 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_410;
				}
				throw ex4;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0002601C File Offset: 0x0002421C
		private static void arrayIndexgetNow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00026034 File Offset: 0x00024234
		private static void RelatedActivityIdgetUnicodeEncoded(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 13;
			A_17 = flag;
			int num = ((!A_17) ? 1 : 0) * 1 + 187;
			A_0 = num;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00026098 File Offset: 0x00024298
		private static void getIsFinalHostEvidence(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_5.GetComponent<Collider>().enabled = false;
			int num = (A_4.MoveNext() ? 1 : 0) * -5 + 106;
			A_0 = num;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000260FC File Offset: 0x000242FC
		private static void CountBrowserForward(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			A_0 = 51;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00026114 File Offset: 0x00024314
		private static void ShortInlineRStrongNamePublicKeyBlob(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			PhotonNetwork.Disconnect();
			Mods.FlushRemoteProceduralCalls();
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 31;
			A_0 = num;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0002616C File Offset: 0x0002436C
		private static void AddStringExitCode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			GradientColorKey[] array = new GradientColorKey[4];
			A_10 = array;
			A_10[0].color = Mods.FirstColor;
			A_10[0].time = 0f;
			A_10[1].color = Mods.FirstColor;
			A_10[1].time = 0.3f;
			A_10[2].color = Mods.SecondColor;
			A_10[2].time = 0.6f;
			A_10[3].color = Mods.SecondColor;
			A_10[3].time = 1f;
			ColorChanger colorChanger = A_7.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			A_11.colors = new Gradient
			{
				colorKeys = A_10
			};
			A_11.Start();
			A_0 = 70;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000262DC File Offset: 0x000244DC
		private static void IsInClsid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool triggerDownR = WristMenu.triggerDownR;
			A_3 = triggerDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 238;
			A_0 = num;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00026338 File Offset: 0x00024538
		public unsafe static void GrabAllHeads()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 269;
			int num4 = 269;
			num4 = 269;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 1)
					{
						num4 = 269;
						if ((int)array[2] != 0)
						{
							num5 = (int)array[0];
							num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 16 + num2);
							for (num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + (int)array[7] + 16 + num2) + 16 + num2); num7 != num6; num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num7 + 16 + num2))
							{
								num8 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num7 + 48 + num2);
								if (num8 != -1)
								{
									num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num8 + 48 + num2);
									array[7] = num8;
									array[5] = 0;
									num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num8 + 48 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[1];
							num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
							ex2 = ex;
							array = (object[])array[3];
							array2 = new object[8];
							array2[2] = 1;
							array2[3] = array;
							array2[1] = ex;
							array2[7] = num5;
							array2[5] = 2;
							array = array2;
							num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
							continue;
						}
						num10 = (int)array[4];
						array = (object[])array[3];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 3)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num3]);
							continue;
						}
						num4 = 269;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num15 * 80 + 24 + num2);
						num17 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num15 * 80 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num7 * 80 + 72 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num14 * 80 + 24 + num2);
						num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num14 * 80 + 16 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num7 * 80 + 72 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num15 * 72 + 16 + num2);
						num17 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num15 * 72 + 24 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num7 * 72 + 64 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D9:
						if (array == null || (int)array[2] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 16 + num2);
								}
								else
								{
									num10 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 48 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 16 + num2);
									goto IL_9D9;
								}
							}
							goto IL_B77;
						}
						int num19 = (int)array[7];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 32 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num15 * 72 + 16 + num2);
								num10 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num15 * 72 + 24 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num5 * 72 + 64 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num7 + 16 + num2);
								}
								else
								{
									num5 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 48 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 16 + num2);
									goto IL_9D9;
								}
							}
							break;
						}
						if ((int)array[7] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[3];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
					array2 = new object[]
					{
						null,
						null,
						0,
						array,
						num11,
						null,
						null,
						num5
					};
					array2[5] = 0;
					array = array2;
					num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B77:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 48 + num2);
					array2 = new object[]
					{
						null,
						null,
						0,
						array,
						num11,
						null,
						null,
						num10
					};
					array2[5] = 0;
					array = array2;
					num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 48 + num2);
				}
				num4 = 269;
				return;
				IL_1C4:
				if (num6 != -1)
				{
					goto IL_1CF;
				}
				goto IL_3F7;
				IL_1CF:
				num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 24 + num2);
				if (1 == num7)
				{
					goto IL_1EE;
				}
				if (2 == num7)
				{
					goto IL_380;
				}
				goto IL_3F7;
				IL_1EE:
				num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 64 + num2);
				if (num9 == -1)
				{
					goto IL_23C;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_222;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_222:
				if (type.IsInstanceOfType(array2[1]))
				{
					goto IL_23C;
				}
				num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 56 + num2);
				goto IL_1C4;
				IL_23C:
				num5 = num6;
				num8 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 16 + num2) + 16 + num2);
				num13 = (int)array2[6];
				IL_260:
				if (num13 != num8)
				{
					goto IL_2DF;
				}
				int num22 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
				ex2 = array2[1];
				array = (object[])array[3];
				object[] array5 = new object[8];
				array5[2] = 1;
				array5[3] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[7] = num5;
				array5[5] = 2;
				array = array5;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
				goto IL_23;
				IL_2DF:
				num18 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num13 + 48 + num2);
				if (num18 == -1)
				{
					goto IL_36E;
				}
				num22 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 48 + num2);
				array = (object[])array[3];
				array5 = new object[8];
				array5[2] = 1;
				array5[3] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[7] = num18;
				array5[0] = num5;
				array5[5] = 0;
				array = array5;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num18 + 48 + num2);
				goto IL_23;
				IL_36E:
				num13 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num13 + 16 + num2);
				goto IL_260;
				IL_380:
				num22 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 8 + num2);
				ex2 = array2[1];
				array = (object[])array[3];
				array5 = new object[8];
				array5[2] = 1;
				array5[3] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[7] = num6;
				array5[5] = 1;
				array = array5;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num6 + 8 + num2);
				goto IL_23;
				IL_3F7:
				array = (object[])array[3];
				Exception ex3 = array2[1];
				int num23 = (int)array2[6];
				IL_416:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_424:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num14 * 80 + 24 + num2);
				num16 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num14 * 80 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_46A;
				}
				if (num15 > num22)
				{
					goto IL_472;
				}
				num8 = num14;
				num5 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 128 + num8 * 80 + 72 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_49A;
				IL_46A:
				num21 = num14 + 1;
				goto IL_424;
				IL_472:
				num10 = num14 - 1;
				goto IL_424;
				IL_49A:
				if (array != null)
				{
					goto IL_4A5;
				}
				goto IL_634;
				IL_4A5:
				if ((int)array[2] != 0)
				{
					goto IL_565;
				}
				int num24 = (int)array[7];
				if (num9 != -1)
				{
					goto IL_4C9;
				}
				int num25 = -1;
				goto IL_54C;
				IL_4C9:
				num17 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num9 + 32 + num2);
				num16 = 0;
				num15 = 2;
				IL_4DC:
				num14 = (num16 + num15) / 2;
				num10 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num14 * 72 + 16 + num2);
				num21 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num14 * 72 + 24 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_522;
				}
				if (num10 > num17)
				{
					goto IL_52A;
				}
				num5 = num14;
				num8 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num5 * 72 + 64 + num2);
				num25 = num8;
				goto IL_54C;
				IL_522:
				num16 = num14 + 1;
				goto IL_4DC;
				IL_52A:
				num15 = num14 - 1;
				goto IL_4DC;
				IL_54C:
				if (num24 != num25)
				{
					goto IL_554;
				}
				goto IL_634;
				IL_554:
				array = (object[])array[3];
				goto IL_49A;
				IL_565:
				num18 = (int)array[5];
				if (num18 == 2 || num18 == 0)
				{
					goto IL_586;
				}
				if (num18 != 1)
				{
					goto IL_585;
				}
				array2 = array;
				num6 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + (int)array2[7] + 56 + num2);
				goto IL_1C4;
				IL_585:
				IL_586:
				int num26 = (int)array[7];
				if (num9 != -1)
				{
					goto IL_59B;
				}
				int num27 = -1;
				goto IL_61E;
				IL_59B:
				num22 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num9 + 32 + num2);
				num21 = 0;
				num10 = 2;
				IL_5AE:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num14 * 72 + 16 + num2);
				num16 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num14 * 72 + 24 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5F4;
				}
				if (num15 > num22)
				{
					goto IL_5FC;
				}
				num8 = num14;
				num5 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + 368 + num8 * 72 + 64 + num2);
				num27 = num5;
				goto IL_61E;
				IL_5F4:
				num21 = num14 + 1;
				goto IL_5AE;
				IL_5FC:
				num10 = num14 - 1;
				goto IL_5AE;
				IL_61E:
				if (num26 != num27)
				{
					goto IL_623;
				}
				goto IL_634;
				IL_623:
				array = (object[])array[3];
				goto IL_49A;
				IL_634:
				if (-1 != num9)
				{
					goto IL_640;
				}
				int num28 = 1;
				throw ex3;
				IL_640:
				num7 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num9 + 8 + num2);
				num10 = num7;
				IL_650:
				if (num10 != -1)
				{
					goto IL_667;
				}
				num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num9 + 16 + num2);
				goto IL_49A;
				IL_667:
				num15 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 24 + num2);
				if (1 == num15)
				{
					goto IL_692;
				}
				if (2 == num15)
				{
					goto IL_800;
				}
				num9 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num9 + 16 + num2);
				goto IL_49A;
				IL_692:
				num14 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 64 + num2);
				if (num14 == -1)
				{
					goto IL_6E1;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6C6;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6C6:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E1;
				}
				num10 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 56 + num2);
				goto IL_650;
				IL_6E1:
				num5 = num10;
				num8 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 16 + num2) + 16 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_70A:
				if (num17 != num8)
				{
					goto IL_773;
				}
				num21 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[2] = 1;
				array2[3] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[7] = num5;
				array2[5] = 2;
				array = array2;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num5 + 48 + num2);
				goto IL_23;
				IL_773:
				num16 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num17 + 48 + num2);
				if (num16 == -1)
				{
					goto IL_7EE;
				}
				num21 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num16 + 48 + num2);
				array2 = new object[8];
				array2[2] = 1;
				array2[3] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[7] = num16;
				array2[0] = num5;
				array2[5] = 0;
				array = array2;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num16 + 48 + num2);
				goto IL_23;
				IL_7EE:
				num17 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num17 + 16 + num2);
				goto IL_70A;
				IL_800:
				num21 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 8 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[2] = 1;
				array2[3] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[7] = num10;
				array2[5] = 1;
				array = array2;
				num3 = *(ref getElementIndexVerbose.RectArrayIMuiResourceMapEntry + num10 + 8 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_416;
				}
				throw ex4;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00026F74 File Offset: 0x00025174
		public static void UpsideDownHead()
		{
			int num = 242;
			int num2 = 242;
			num2 = 242;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 242;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00026FB8 File Offset: 0x000251B8
		private static void TargetTypeTokengetSign(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00026FDC File Offset: 0x000251DC
		private static void AppIdAuthoritySerializationBinder(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref string A_9, ref int A_10, ref Transform A_11, ref bool A_12, ref Text A_13, ref Transform A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref float A_21, ref bool A_22, ref bool A_23, ref bool A_24)
		{
			Text component = A_11.Find("Player Name").GetComponent<Text>();
			A_13 = component;
			Transform transform = A_11.Find("ReportButton");
			A_14 = transform;
			bool flag = !A_14.gameObject.activeSelf;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 13 + 21;
			A_0 = num;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0002709C File Offset: 0x0002529C
		private static void GetRuntimeTypeHandleFromMetadataTokenIsPrivate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 255;
			A_0 = num;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000270F8 File Offset: 0x000252F8
		private static void NoFreeBuffersEqualsExact(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref GameObject A_7, ref LineRenderer A_8, ref bool A_9, ref GradientColorKey[] A_10, ref ColorChanger A_11)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -7 + 73;
			A_0 = num;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00027140 File Offset: 0x00025340
		private static void MemberChildgetImplementedInterfaces(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6, ref GradientColorKey[] A_7, ref ColorChanger A_8, ref bool A_9)
		{
			GorillaTagger.Instance.rigidbody.transform.position = Mods.pointer.transform.position;
			A_0 = 354;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00027180 File Offset: 0x00025380
		private static void AssemblyReferenceDependentAssemblyEntryFieldIdgetAsBool(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaTagger.Instance.handTapVolume = 0.1f;
			A_1 = 0;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000271A8 File Offset: 0x000253A8
		private static void FactoryNumAmpm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref bool A_19, ref bool A_20, ref bool A_21, ref bool A_22, bool A_23)
		{
			bool flag = Mods.DickIsTiny == 0;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 161;
			A_0 = num;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0002720C File Offset: 0x0002540C
		public static void DisableInstantHandTaps()
		{
			int num = 261;
			int num2 = 261;
			num2 = 261;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[num]);
			}
			num2 = 261;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00027250 File Offset: 0x00025450
		private static void ControlIsAppEarlierThanSilverlight()
		{
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter = new IntPtr[469];
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[0] = ldftn(ISymbolDocumentgetEventHandle);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[1] = ldftn(ConstructorInfoOperationCompleted);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[2] = ldftn(getIsContextfulTKINDENUM);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[3] = ldftn(getIsBackgroundCodeBase);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[4] = ldftn(DefineMethodOverrideJapaneseLunisolarCalendar);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[5] = ldftn(TKINDMAXgetLargestWindowWidth);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[6] = ldftn(FlushHexIntPtrType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[7] = ldftn(getAppendCommonProgramFiles);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[8] = ldftn(TokenRestrictedDeviceClaimAttributesLocal);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[9] = ldftn(CoClassAttributesetViewAndModify);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[10] = ldftn(AsUintSoapAction);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[11] = ldftn(ProgIdRedirectionEntryFieldIdNN);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[12] = ldftn(ToDecimalMuiResourceTypeIdStringStringIds);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[13] = ldftn(getMinSizeGuid);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[14] = ldftn(getNumberLockResourceSet);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[15] = ldftn(getTrackResurrectiongetResources);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[16] = ldftn(DateTimeResultsetApartmentState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[17] = ldftn(TablesClassName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[18] = ldftn(getSourceNamegetCurrencyGroupSizes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[19] = ldftn(HandlerLengthFromEventKeywords);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[20] = ldftn(AppIdAuthoritySerializationBinder);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[21] = ldftn(getANSICodePageSecureStringToGlobalAllocAnsi);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[22] = ldftn(MLangDecoderLongEnumEqualityComparer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[23] = ldftn(ModuleGetDocument);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[24] = ldftn(removeDesignerNamespaceResolveEvidenceTypeGenerated);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[25] = ldftn(DebuggerBrowsableAttributeStreamTokenReader);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[26] = ldftn(getAccessEntriesgetMaxGeneration);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[27] = ldftn(ShortInlineRStrongNamePublicKeyBlob);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[28] = ldftn(INVOKEPROPERTYPUTAddOvf);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[29] = ldftn(CurrentEraIEnumerator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[30] = ldftn(FinalEuropeanNumberSeparator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[31] = ldftn(GetDeclaredMethodsdCreatePageFile);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[32] = ldftn(setCheckExecutionRightsgetKeyName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[33] = ldftn(MyMusicBindHandle);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[34] = ldftn(StoppedRethrow);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[35] = ldftn(RemoveInheritedAcesGuidResult);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[36] = ldftn(AllowEventSourceOverridegetEvidenceObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[37] = ldftn(GetAssemblyIdentityMDStreamVersion);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[38] = ldftn(WindowsBuiltInRolecbSizeVft);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[39] = ldftn(DangerousGetRawSecurityContextMulOvf);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[40] = ldftn(getAssemblyIsPrivateSecureStringToCoTaskMemUnicode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[41] = ldftn(IdentityReferenceInstantiationArgs);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[42] = ldftn(UTFByteArraySkipVerification);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[43] = ldftn(GetUnmanagedThunkForManagedMethodPtrLocalDateTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[44] = ldftn(CountBrowserForward);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[45] = ldftn(ReadOnlyDictionaryKeyCollectiongetUseMachineKeyStore);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[46] = ldftn(AssemblyFormatDeclaredMembers);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[47] = ldftn(getMemberBasic);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[48] = ldftn(CModOptIsMemberRef);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[49] = ldftn(GuidStylesLockMemory);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[50] = ldftn(IsNegativeInfinitygetIsWriterLockHeld);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[51] = ldftn(OrderablePartitionerDynamicPartitionerForIndexRangeAbstract);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[52] = ldftn(IntPtrTypeEmptyStruct);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[53] = ldftn(smallResulteFixedBufferCurrentUser);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[54] = ldftn(IProgIdRedirectionEntryMarshaledObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[55] = ldftn(setReflectionEmitGetValueKind);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[56] = ldftn(ContainedInAnotherAssemblyVariantType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[57] = ldftn(LdargaAsInt);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[58] = ldftn(ConfiguredTaskAwaitableSearchOption);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[59] = ldftn(getIsSingleBytegetApplicationEvidence);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[60] = ldftn(InsertRangeGlobalResourceContextBestFitCultureInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[61] = ldftn(LogMessageCOREDIRECTORYNOTFOUND);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[62] = ldftn(CreatePermanentEventHandle);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[63] = ldftn(DateUnknown);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[64] = ldftn(UnwrapGetHashFromBlob);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[65] = ldftn(CallConvThiscallJapaneseCalendar);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[66] = ldftn(getMetadataSectionEntryCoClassAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[67] = ldftn(IResourceGrovelerCspParameters);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[68] = ldftn(AddStringExitCode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[69] = ldftn(getIsGenericParameterConcurrentStackFastPushFailed);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[70] = ldftn(clsidNoOptimization);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[71] = ldftn(GetSrcItfTypeStable);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[72] = ldftn(NoFreeBuffersEqualsExact);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[73] = ldftn(ArgumentsGetOneYearLocalFromUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[74] = ldftn(GetConstructorTokenNonSerializedAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[75] = ldftn(ListDictionaryInternalConsoleCancelEventHandler);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[76] = ldftn(setVersionAddedGetSingleArray);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[77] = ldftn(TKINDINTERFACEObjectDisposedException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[78] = ldftn(PopipoprRuntimeInformation);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[79] = ldftn(UseNonExportableKeySuppressChangeType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[80] = ldftn(getSubjectGetElement);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[81] = ldftn(ReadBlockAsyncCheckedForAsync);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[82] = ldftn(AutoShr);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[83] = ldftn(NonSerializedAttributegetAssemblyEvidence);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[84] = ldftn(CurrentAssemblyCryptAcquireContextFlags);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[85] = ldftn(TokenOriginMuiResourceMapEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[86] = ldftn(PopipopiPOLICYAUDITLOGADMIN);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[87] = ldftn(CreateComInstanceFromcImplTypes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[88] = ldftn(ObjectMarshalerIDescriptionMetadataEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[89] = ldftn(SetLengthToFirstNullLoaderExceptions);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[90] = ldftn(ParallelLoopBeginUIntArrayTypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[91] = ldftn(NewPermissionElementEventProviderWriter);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[92] = ldftn(getEntryAssemblygetLastWriteTimeUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[93] = ldftn(GetFieldFromHandleAdjustGroups);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[94] = ldftn(getKeyPasswordgetValueCount);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[95] = ldftn(CCMAXDidNotExist);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[96] = ldftn(ControlThreadmname);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[97] = ldftn(setHijriAdjustmentsetObjectMode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[98] = ldftn(BindTypeEventFieldTags);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[99] = ldftn(BrowserRefreshcFileNameeFixedBuffer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[100] = ldftn(fAnonymousTypeCurrentManagedThreadId);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[101] = ldftn(MapToCollectionAdapterComObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[102] = ldftn(setTaskClass);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[103] = ldftn(getIsFinalHostEvidence);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[104] = ldftn(IsComObjectCacheType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[105] = ldftn(NestedPrivateReadToEndAsyncInternald);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[106] = ldftn(listHashElements);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[107] = ldftn(ITracingStatusChangedEventArgsAllocHGlobal);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[108] = ldftn(GetSizeMaxgetIsSystem);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[109] = ldftn(IsLowerRevertDeny);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[110] = ldftn(IsControlEvidenceType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[111] = ldftn(getEvidenceObjectAuthenticated);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[112] = ldftn(MachineKeysetCreatePermissionSet);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[113] = ldftn(NAMEsetTargetFrameworkName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[114] = ldftn(GetParamDefPropsLocalServer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[115] = ldftn(TypesIsMetric);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[116] = ldftn(GetSetMethodgetPublicOnly);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[117] = ldftn(setPercentGroupSizesCleanupCode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[118] = ldftn(RegionInfoCommonPrograms);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[119] = ldftn(HasIdentitiesDefinitionIdentity);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[120] = ldftn(ExternalThreadingTypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[121] = ldftn(GetNextCharTimerCallback);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[122] = ldftn(SetPublicKeyReadOnlyCollectionBase);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[123] = ldftn(ToStringHelperFuncReadAllBytes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[124] = ldftn(RestSetApplicationRunningState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[125] = ldftn(InitializeLifetimeServiceremoveCancelKeyPress);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[126] = ldftn(ObjectWithMapWriteAttributes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[127] = ldftn(setCurrencyGroupSizesPriority);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[128] = ldftn(ModeInvalidEscapeContinuationResultTaskFromResultTask);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[129] = ldftn(PermissionSetTripleRuntimeFieldInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[130] = ldftn(SpecialFolderOptionMonthDatesep);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[131] = ldftn(EVENTACTIVITYCTRLCREATESETIDStat);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[132] = ldftn(SharedStateFReplaceable);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[133] = ldftn(VTDATEgetDays);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[134] = ldftn(getStringMethodName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[135] = ldftn(HandleCreateAnySchemeAccess);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[136] = ldftn(AllowThousandsEnumerablePartitionerOptions);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[137] = ldftn(PublicationOnlyLargestWindowWidth);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[138] = ldftn(CharUnknownsetCalendarType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[139] = ldftn(getIsRelativeFileUrlDangerousGetRawSecurityContext);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[140] = ldftn(RNGCryptoServiceProviderPermissionSetAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[141] = ldftn(PaddingModeEnglishName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[142] = ldftn(PrepareDelegateInternalPartitionEnumerable);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[143] = ldftn(RfcDeriveBytesSingleArray);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[144] = ldftn(FieldAccessMaskgetXmlFieldOrder);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[145] = ldftn(FieldAccessMaskDeploymentMetadataEntryFieldId);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[146] = ldftn(GetHostEnumeratorUri);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[147] = ldftn(getIsOptionalLdfld);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[148] = ldftn(ConcurrentStackIsAppEarlierThanSilverlight);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[149] = ldftn(getBytesUnknownsetCheckExecutionRights);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[150] = ldftn(BindLockRegion);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[151] = ldftn(XmlSegmentMAJORVERSION);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[152] = ldftn(DSObjectAllgetDateTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[153] = ldftn(DataAvailablegetWriterSeqNum);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[154] = ldftn(RegistryViewSystemEnvironment);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[155] = ldftn(getAccessMuiResourceMapResourceTypeIdString);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[156] = ldftn(SystemAlarmCallbackDP);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[157] = ldftn(ExternalThreadingTransparent);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[158] = ldftn(getDirectorySectionSetCode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[159] = ldftn(RelaxedSignaturesetSelfAffectingThreading);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[160] = ldftn(FactoryNumAmpm);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[161] = ldftn(getTypesCMSASSEMBLYREFERENCEFLAGCULTUREWILDCARDED);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[162] = ldftn(IsSecurityTransparentViewAcl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[163] = ldftn(MAXPARAMSgetIsAppEarlierThanWindowsPhoneMango);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[164] = ldftn(IsSingleBytegetBigEndianUnicode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[165] = ldftn(BrSIDispatchImplType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[166] = ldftn(BeginThreadAffinityAwayFromZero);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[167] = ldftn(getIsCompatibilityBehaviorDefinedPercentGroupSeparator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[168] = ldftn(InlineTokSystemAclAutoInherited);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[169] = ldftn(getIsNestedFamANDAssemgetTypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[170] = ldftn(SZArrayEnumeratorInit);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[171] = ldftn(ProcessArchitecturegetViewAccessControl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[172] = ldftn(removeEventSourceCreatedgetEncoderFallback);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[173] = ldftn(GetSourcessetShadowCopyFiles);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[174] = ldftn(getIsReadOnlyEVENTACTIVITYCTRLGETID);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[175] = ldftn(LiveActivitiesWindowsRuntimeMarshal);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[176] = ldftn(ArgumentItemNotExistgetIsOut);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[177] = ldftn(MemberCountBinderState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[178] = ldftn(AccessRuleFactoryBlockLongPaths);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[179] = ldftn(TYPEFLAGFCANCREATELeftAltPressed);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[180] = ldftn(getDateEtwEnableCallback);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[181] = ldftn(JitImmediateControlBreak);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[182] = ldftn(IEnumDefinitionIdentityIntrospectiveSortUtilities);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[183] = ldftn(getTotalMinutesBlack);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[184] = ldftn(getDriveTypePoint);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[185] = ldftn(SystemThreadingTasksTaskSchedulerDebugViewsetCalendarType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[186] = ldftn(RelatedActivityIdgetUnicodeEncoded);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[187] = ldftn(getInvalidCultureNameTypeEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[188] = ldftn(setMonitoringIsEnabledPolicy);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[189] = ldftn(getQuotaDiscretionaryAclProtected);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[190] = ldftn(setAsUintTNt);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[191] = ldftn(getSetupInformationBigEndianUnicode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[192] = ldftn(ArchivableBinaryMethodReturnMessage);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[193] = ldftn(LeaseManagerPollTimeRealErrorObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[194] = ldftn(getSortIdArgumentNull);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[195] = ldftn(getIsAliveDefineUnmanagedResource);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[196] = ldftn(TextElementEnumeratorTrusted);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[197] = ldftn(BuildNumberDelegateEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[198] = ldftn(TargetTypeTokengetSign);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[199] = ldftn(CMSHASHDIGESTMETHODSHAbucket);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[200] = ldftn(XmlElementPOLICYCREATESECRET);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[201] = ldftn(GetActivationFactorygetIsInterface);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[202] = ldftn(ImportantsetCodeBase);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[203] = ldftn(OtherNotAssignedFaultCode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[204] = ldftn(UnmanagedMemoryStreamWrapperscheduler);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[205] = ldftn(IDLFLAGNONEEnabledForAnyListener);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[206] = ldftn(CriticalHandlePEPlus);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[207] = ldftn(getTimeOfDayDBNull);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[208] = ldftn(MonthSpaceGetDecimal);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[209] = ldftn(getLocalForegroundMask);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[210] = ldftn(HeadersEndModifyAuditRule);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[211] = ldftn(IFileAssociationEntryStrongNameKeyGenEx);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[212] = ldftn(getCergetHost);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[213] = ldftn(UTFEncodingSealedISecurityEncodable);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[214] = ldftn(getOpCodeTypePropertyAnalysis);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[215] = ldftn(MdSigCallingConventionsetMemberAccess);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[216] = ldftn(PushiFullControl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[217] = ldftn(ThreadPoolTaskSchedulerEnsureInitialized);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[218] = ldftn(UtcTicksHasTrueValue);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[219] = ldftn(IntArraygetAbbreviatedDayNames);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[220] = ldftn(getSkipVerificationAddSeconds);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[221] = ldftn(PrePrepareMethodAttributesetLevel);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[222] = ldftn(getOriginalIssuerSecurityRuleSet);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[223] = ldftn(ArgMapperGetTypeForITypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[224] = ldftn(BinaryWritergetIsTypeSpec);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[225] = ldftn(ServerWellKnownEntryToEventKeywords);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[226] = ldftn(MakeGenericMethodCreateProxy);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[227] = ldftn(AuditFlagsCountedUtfXml);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[228] = ldftn(HashElementTransformGetTypeComp);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[229] = ldftn(SetHandledCalculateDelimiterOfDeploymentsBasedOnQuota);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[230] = ldftn(CustomAttributeNamedArgumentReadLinesIterator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[231] = ldftn(ResetColorFirstChanceExceptionEventArgs);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[232] = ldftn(RFCPatternManifestModule);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[233] = ldftn(NameIdentifierThisCall);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[234] = ldftn(MulticastDelegateNotOnFaulted);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[235] = ldftn(getRelativeSearchPathCausalityRelation);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[236] = ldftn(BStrWrapperDispatchChannelSink);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[237] = ldftn(IsInClsid);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[238] = ldftn(HOSTEDFrameSecurityDescriptorWithResolver);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[239] = ldftn(MetadataSectionRequestedExecutionLevelUIAccessGetOrderablePartitions);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[240] = ldftn(NoInlininggetUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[241] = ldftn(arrayIndexgetNow);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[242] = ldftn(EntryContextMarshalException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[243] = ldftn(ObjectStringAsDate);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[244] = ldftn(RegistryViewSystemException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[245] = ldftn(LockRegionNoRootDirectory);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[246] = ldftn(EndGetResponseIMPFASTFLOW);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[247] = ldftn(ExportAsBitT);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[248] = ldftn(RequireFullexceptionQ);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[249] = ldftn(AppDomainInitializerInfoIsSecured);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[250] = ldftn(ITypeInfoCOREISOSTORE);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[251] = ldftn(RegisteredChannelApplicationBasePath);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[252] = ldftn(CountdownEventAppDomainTimerSafeHandle);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[253] = ldftn(NternalComImportAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[254] = ldftn(GetRuntimeTypeHandleFromMetadataTokenIsPrivate);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[255] = ldftn(DNNdGetGuid);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[256] = ldftn(TimeZoneInfoOpcodes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[257] = ldftn(SetupInformationRoundtripKind);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[258] = ldftn(FilterNameFromOADate);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[259] = ldftn(AreAccessRulesCanonicalDecryptValue);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[260] = ldftn(GetExceptionPointerssetEventChannelType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[261] = ldftn(CustomAttributeNamedParameterSetContextNameObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[262] = ldftn(AssemblyReferenceDependentAssemblyEntryFieldIdgetAsBool);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[263] = ldftn(getIsAssemblyMarkSequencePoint);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[264] = ldftn(DXNNYCollection);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[265] = ldftn(ContextInArrayTypeSpec);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[266] = ldftn(getMinutesDesktopDirectory);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[267] = ldftn(VisibilityMaskPackageSimpleName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[268] = ldftn(AbbreviatedMonthNamesCommonNumberSeparator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[269] = ldftn(StandardTaskContinuationgetIsThreadOwnerTrackingEnabled);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[270] = ldftn(PushRangeSECURITYIMPERSONATIONLEVEL);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[271] = ldftn(AddValuePayload);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[272] = ldftn(SetEnvironmentVariablesetAbbreviatedMonthNames);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[273] = ldftn(getIgnorePortablePDBsInStackTracesgetThreadState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[274] = ldftn(STAThreadAttributegetCondition);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[275] = ldftn(ReadToEndAsyncInternaldLSATRUSTINFORMATION);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[276] = ldftn(MethodNamegetChannelScheme);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[277] = ldftn(TraceFormatsetMinimumLevel);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[278] = ldftn(EnumPrivateFilesLeaseManagerPollTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[279] = ldftn(getScheduledConcurrentStoreOperationSetCanonicalizationContext);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[280] = ldftn(ZeroFreeCoTaskMemAnsiGetHostEvidence);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[281] = ldftn(getBlockSizeValueRemoveAudit);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[282] = ldftn(getHostCanGenerategetMinimumRequiredVersion);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[283] = ldftn(GBDecodergetPropertyName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[284] = ldftn(getIsHeldBinaryMethodReturnMessage);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[285] = ldftn(RuntimeWrappedExceptionShadowCopyFilesValue);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[286] = ldftn(GetXmlElementForInteropTypeDelete);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[287] = ldftn(ResolveNamespacegetParameter);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[288] = ldftn(UCOMIEnumConnectionPointsgetTimeOfDay);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[289] = ldftn(bstrDescriptionDateTimeStyles);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[290] = ldftn(LocalFindAndPopTimeZoneNotFoundException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[291] = ldftn(MemberPrimitiveTypedGetPropertySigHelper);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[292] = ldftn(ArabicCLRIPropertyValueImpl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[293] = ldftn(EscapeThreadTransferSendObj);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[294] = ldftn(FuncInvalidOperationRegRemoveSubKey);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[295] = ldftn(StackBehaviourPushsetRenewalTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[296] = ldftn(WSetFault);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[297] = ldftn(getMemberTypeByteTypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[298] = ldftn(EventSourceCreatedEventArgsGetGenericParameterConstraints);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[299] = ldftn(NativeNameCreateActContextParametersSourceDefinitionAppid);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[300] = ldftn(getScheduledConcurrentSecurityRegistryPermission);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[301] = ldftn(fVersionedProduct);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[302] = ldftn(IConnectionPointContainergetCommandLineFile);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[303] = ldftn(FNonExtensiblePermissionRequestEvidence);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[304] = ldftn(IsTypeDefAllowLeadingWhite);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[305] = ldftn(EnvironmentBITONLY);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[306] = ldftn(UnsafePackCharUnknownHigh);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[307] = ldftn(setHashNameParent);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[308] = ldftn(IdManagersetUIContext);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[309] = ldftn(getTwoLetterISOLanguageNameFieldOnTypeBuilderInstantiation);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[310] = ldftn(GetFieldSigHelperRunImpersonated);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[311] = ldftn(GetViewISerializationSurrogate);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[312] = ldftn(TraceLoggingMetadataCollectorSaturday);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[313] = ldftn(SeparatorTokenMaskSetShadowCopyPath);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[314] = ldftn(NormalizationFormSetOnInvokeMres);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[315] = ldftn(viewGlobalizationExtensions);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[316] = ldftn(SetCheckSumHasCurrent);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[317] = ldftn(setPercentPositivePatternOffsetAndRule);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[318] = ldftn(HashCollisionThresholdTimeZoneUsed);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[319] = ldftn(IsObjectOutOfAppDomaingetXmlNameSpace);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[320] = ldftn(AppDomainUnloadedExceptionConfigure);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[321] = ldftn(IMapViewBLOB);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[322] = ldftn(LocalApplicationDataStelemI);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[323] = ldftn(OFBIsolatedStorageSecurityState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[324] = ldftn(OnFinalReleaseReceiveHandled);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[325] = ldftn(TrimFreeSizeOKIsAppEarlierThanSilverlight);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[326] = ldftn(CollectFromServerContextSoapParameterAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[327] = ldftn(ApplicationEvidenceSTORECATEGORY);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[328] = ldftn(getIsArrayBackPropAction);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[329] = ldftn(PausingADAsyncWorkItem);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[330] = ldftn(GetDomainRemotingTimeoutException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[331] = ldftn(ResourceManagerNeutralResourcesNotFoundSetLocalSignature);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[332] = ldftn(setMembershipConditionXsdString);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[333] = ldftn(IReflectOpCodes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[334] = ldftn(EmptyReadOnlyDictionaryInternalgetDefaultRequestSet);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[335] = ldftn(getBinderIsSupported);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[336] = ldftn(BneUnMuiResourceIdLookupMapEntryFieldId);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[337] = ldftn(getArgumentTypeAppendFormat);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[338] = ldftn(getUserMessageCryptoKeySecurity);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[339] = ldftn(AppDomainLevelActivatorFUNCVIRTUAL);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[340] = ldftn(TYPEFLAGFREVERSEBINDbodyWithState);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[341] = ldftn(EncodedEnumTypeGO);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[342] = ldftn(CastGO);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[343] = ldftn(IReferenceIdentitySupportUrl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[344] = ldftn(SystemThreadingTasksFutureDebugViewSetMessageCtrl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[345] = ldftn(ChannelUrisYield);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[346] = ldftn(BrowserBackaction);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[347] = ldftn(GetMachineStoreForAssemblyQuerySource);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[348] = ldftn(SeedgetMachineKeyStore);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[349] = ldftn(RCDirectorySeparatorChar);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[350] = ldftn(MonthDefinitionAppIdApplication);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[351] = ldftn(MemberChildgetImplementedInterfaces);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[352] = ldftn(SetSecurityDescriptorBinaryFormGetInt);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[353] = ldftn(TraceLoggingDataCollectorIsNetFxLegacySecurityPolicy);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[354] = ldftn(EncryptAddChannel);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[355] = ldftn(getAvailableFreeSpaceSIDANDATTRIBUTES);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[356] = ldftn(MoveIsolatedStorageFile);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[357] = ldftn(CommonOemLinksMoveTimerToCorrectList);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[358] = ldftn(setWriteTimeoutgetFactory);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[359] = ldftn(FormatIntgetMacCodePage);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[360] = ldftn(SingleDomainIKeyValuePair);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[361] = ldftn(DarkCyanGetUninitializedObject);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[362] = ldftn(IsNullTokenTryGetBuffer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[363] = ldftn(ReferenceIdentityDefinitionToText);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[364] = ldftn(PassesActivityFilterIMPFASTFLOW);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[365] = ldftn(CalliConvertTimeToUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[366] = ldftn(SynchronizedListNoInlining);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[367] = ldftn(FNonExtensibleGetStore);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[368] = ldftn(InheritedObjectAceTypeStringInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[369] = ldftn(getMaximumAgeUnitGetCOMIUnknown);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[370] = ldftn(ThreadTransferReceiveHandledObjgetKeyFile);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[371] = ldftn(GetDynamicPartitionsaddProcessExit);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[372] = ldftn(INVOCATIONFLAGSISCTORAsUi);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[373] = ldftn(mpublicKeyBlobGetEncoding);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[374] = ldftn(HourgetDigestMethod);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[375] = ldftn(getDeclaredEventsSoapHexBinary);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[376] = ldftn(FormatAssemblyAsDate);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[377] = ldftn(GuidHours);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[378] = ldftn(VBByValStrMarshalerVerbose);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[379] = ldftn(ThrowOnUnmappableCharDisabledopSubtraction);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[380] = ldftn(SetActorAsReferenceWhenCopyingClaimsIdentityBStrWrapper);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[381] = ldftn(InternalApplicationIdentityHelperQueueSegment);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[382] = ldftn(grfLocksSupportedgetSetActorAsReferenceWhenCopyingClaimsIdentity);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[383] = ldftn(ToStringHelperFuncTreatAsSafe);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[384] = ldftn(EncodingTableGetDouble);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[385] = ldftn(PfxStartListening);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[386] = ldftn(getSystemConfigurationFileGetDayOfMonth);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[387] = ldftn(ByteTokenEncodingWaitingToRun);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[388] = ldftn(AbbreviatedMonthNamesTupleExtensions);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[389] = ldftn(getWorkingSetGetSurrogateForCyclicalReference);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[390] = ldftn(GetBooleanArrayRemotingSurrogateSelector);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[391] = ldftn(MethodBodySmuggledMethodCallMessage);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[392] = ldftn(ArgumentOutOfRangeExceptionCCMPWPASCAL);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[393] = ldftn(AppContextDefaultValuesIsNetFxLegacySecurityPolicy);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[394] = ldftn(GetFilterStoreSubcategoryEnumeration);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[395] = ldftn(HashElementXmlGetHostSuppliedAssemblyEvidenceTypes);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[396] = ldftn(ConvertTypeLibToAssemblyStoreDeploymentMetadataPropertyEnumeration);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[397] = ldftn(BinaryAssemblyInfoDefineNestedType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[398] = ldftn(FullSystemTimeCanBeCanceled);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[399] = ldftn(AllowPartiallyTrustedCallersAttributeMemberInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[400] = ldftn(VersionResultParentField);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[401] = ldftn(CompressedStackSwitcherAccountOperator);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[402] = ldftn(GetDayOfMonthArabicNumber);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[403] = ldftn(BraceFormatGetEnvoySink);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[404] = ldftn(AllowParenthesisAptca);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[405] = ldftn(CurrentStateCompareExchange);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[406] = ldftn(BigEndianUnicodeCopyFromIndirect);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[407] = ldftn(getLocalMaxOpaqueLength);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[408] = ldftn(setAceFlagsIMPLTYPEFLAGFSOURCE);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[409] = ldftn(GetAllCustDataClientWellKnownEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[410] = ldftn(AssemblyRefUCOMIStream);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[411] = ldftn(GetFieldCollectFromServerContext);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[412] = ldftn(InvalidOperationCannotRemoveFromStackOrQueuegetActivationArguments);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[413] = ldftn(DYMgetLastWriteTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[414] = ldftn(DeploymentStrongNameIdentityPermissionAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[415] = ldftn(getEndInvokeCalledConvertTimeFromUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[416] = ldftn(setDeformatterAlgorithmListDirectory);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[417] = ldftn(GregorianCalendarHelpersetLatencyMode);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[418] = ldftn(TXTSSystemAclProtected);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[419] = ldftn(SetTypedReferencevt);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[420] = ldftn(GetAtHaveSecond);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[421] = ldftn(DefaultNameClaimTyperangeManager);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[422] = ldftn(StringTypeInfogetComparer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[423] = ldftn(setFirstDayOfWeekCreateDomain);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[424] = ldftn(DefineDefaultConstructorsetFirstPermissionThatFailed);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[425] = ldftn(getAttributeTypeCannotUnloadAppDomainException);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[426] = ldftn(MdSigCallingConventionNIname);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[427] = ldftn(FromOACurrencyLocalBuilder);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[428] = ldftn(ConfiguredTaskAwaiterVARDISPATCH);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[429] = ldftn(HashElementTransformProxy);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[430] = ldftn(PlusGetType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[431] = ldftn(TimeSpanRawInfoServerWellKnownEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[432] = ldftn(PostconditiongetLastWriteTime);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[433] = ldftn(KindIsFromThisAppDomain);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[434] = ldftn(FileAssociationEntryFieldIdgetBlockSizeValue);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[435] = ldftn(IBindableIteratorGetFuncDesc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[436] = ldftn(IsClrTypeNamespaceDynamicPartitionerForArray);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[437] = ldftn(TypesAlwaysIsPrimitive);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[438] = ldftn(CommonDesktopDirectoryRetargetable);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[439] = ldftn(AddAuditgetIsRetval);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[440] = ldftn(ReadCacheCompatibleFrameworksMetadataEntryFieldId);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[441] = ldftn(getDefaultValueTypeConstructorName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[442] = ldftn(TruesetWindowWidth);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[443] = ldftn(RemoveSpecificMemoryStream);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[444] = ldftn(getContainsGenericParametersEncodedArrayType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[445] = ldftn(SetAsNULLCustomErrorsEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[446] = ldftn(FreeBufferNullContextAttributeEntry);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[447] = ldftn(SizeArraySingleArrayTypeInfo);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[448] = ldftn(UniversalTimeUmAlQuraCalendar);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[449] = ldftn(BrtrueILAssembly);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[450] = ldftn(HebrewNumberCdecl);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[451] = ldftn(PersianCalendarIterationCount);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[452] = ldftn(DESCKINDVARDESCCloseScope);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[453] = ldftn(getEncodedEnumTypeCompatibleComparer);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[454] = ldftn(ReflectionOnlyFinish);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[455] = ldftn(getCommandLineParametersGetParameters);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[456] = ldftn(IIDENTITYAUTHORITYDEFINITIONIDENTITYTOTEXTFLAGCANONICALFullName);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[457] = ldftn(GenericPrincipalUniversalSortableDateTimePattern);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[458] = ldftn(HebrewErasetMonthNames);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[459] = ldftn(ArgumentAddingDuplicatePOLICYSERVERADMIN);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[460] = ldftn(DXNNYIMPLTYPEFLAGS);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[461] = ldftn(ExceptionHandlingClauseMonday);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[462] = ldftn(PercentDecimalSeparatorASCII);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[463] = ldftn(FirstMatchCodeGroupIContextAttribute);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[464] = ldftn(IsUppergetObjectAceType);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[465] = ldftn(LdelemaSTA);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[466] = ldftn(cancellationTokenSetLastError);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[467] = ldftn(getPercentDecimalSeparatorSetLastAccessTimeUtc);
			Mods.getAppDomainInitializerArgumentsWinRTTypeNameConverter[468] = ldftn(RSACryptoServiceProvidersetControlDomainPolicy);
		}

		// Token: 0x04000070 RID: 112
		public static bool oiwefkwenfjk;

		// Token: 0x04000071 RID: 113
		public static bool inSettings;

		// Token: 0x04000072 RID: 114
		public static float flySpeed;

		// Token: 0x04000073 RID: 115
		public static int flySpeedCycle;

		// Token: 0x04000074 RID: 116
		public static int TurnGay;

		// Token: 0x04000075 RID: 117
		public static float projDebounce;

		// Token: 0x04000076 RID: 118
		public static float ShotsFired;

		// Token: 0x04000077 RID: 119
		public static float Delay;

		// Token: 0x04000078 RID: 120
		public static float Jumpthing;

		// Token: 0x04000079 RID: 121
		public static bool Fix;

		// Token: 0x0400007A RID: 122
		public static bool IsGay;

		// Token: 0x0400007B RID: 123
		public static int DickIsTiny;

		// Token: 0x0400007C RID: 124
		public static Camera MainT;

		// Token: 0x0400007D RID: 125
		public static bool PCUser;

		// Token: 0x0400007E RID: 126
		public static float sizeScale;

		// Token: 0x0400007F RID: 127
		public static Color FirstColor;

		// Token: 0x04000080 RID: 128
		public static Color SecondColor;

		// Token: 0x04000081 RID: 129
		public static bool ChangingColors;

		// Token: 0x04000082 RID: 130
		public static float Deli;

		// Token: 0x04000083 RID: 131
		public static bool invisplat;

		// Token: 0x04000084 RID: 132
		public static bool stickyplatforms;

		// Token: 0x04000085 RID: 133
		public static GameObject funn;

		// Token: 0x04000086 RID: 134
		public static bool fpcc;

		// Token: 0x04000087 RID: 135
		public static GameObject pointer;

		// Token: 0x04000088 RID: 136
		private static Vector3 scale;

		// Token: 0x04000089 RID: 137
		private static bool once_left;

		// Token: 0x0400008A RID: 138
		private static bool once_right;

		// Token: 0x0400008B RID: 139
		private static bool once_left_false;

		// Token: 0x0400008C RID: 140
		private static bool once_right_false;

		// Token: 0x0400008D RID: 141
		private static bool once_networking;

		// Token: 0x0400008E RID: 142
		private static GameObject[] jump_left_network;

		// Token: 0x0400008F RID: 143
		private static GameObject[] jump_right_network;

		// Token: 0x04000090 RID: 144
		private static GameObject jump_left_local;

		// Token: 0x04000091 RID: 145
		private static GameObject jump_right_local;

		// Token: 0x04000092 RID: 146
		private static GradientColorKey[] colorKeysPlatformMonke;

		// Token: 0x04000093 RID: 147
		private static Vector3? checkpointPos;

		// Token: 0x04000094 RID: 148
		private static IntPtr[] getAppDomainInitializerArgumentsWinRTTypeNameConverter;
	}
}
