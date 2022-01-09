﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_engine
{
    public class Rules
    {

		public static int[][] KnightMoves = new[]
		{
			new[]{ 10, 17,},	//0
			new[]{ 16, 11, 18,},	//1
			new[]{ 8, 17, 12, 19,},	//2
			new[]{ 9, 18, 13, 20,},	//3
			new[]{ 10, 19, 14, 21,},	//4
			new[]{ 11, 20, 15, 22,},	//5
			new[]{ 12, 21, 23,},	//6
			new[]{ 13, 22,},	//7
			new[]{ 18, 25, 2,},	//8
			new[]{ 24, 19, 26, 3,},	//9
			new[]{ 16, 25, 20, 27, 4, 0,},	//10
			new[]{ 17, 26, 21, 28, 5, 1,},	//11
			new[]{ 18, 27, 22, 29, 6, 2,},	//12
			new[]{ 19, 28, 23, 30, 7, 3,},	//13
			new[]{ 20, 29, 31, 4,},	//14
			new[]{ 21, 30, 5,},	//15
			new[]{ 26, 33, 1, 10,},	//16
			new[]{ 32, 27, 34, 2, 11, 0,},	//17
			new[]{ 24, 33, 28, 35, 3, 12, 8, 1,},	//18
			new[]{ 25, 34, 29, 36, 4, 13, 9, 2,},	//19
			new[]{ 26, 35, 30, 37, 5, 14, 10, 3,},	//20
			new[]{ 27, 36, 31, 38, 6, 15, 11, 4,},	//21
			new[]{ 28, 37, 39, 7, 12, 5,},	//22
			new[]{ 29, 38, 13, 6,},	//23
			new[]{ 34, 41, 9, 18,},	//24
			new[]{ 40, 35, 42, 10, 19, 8,},	//25
			new[]{ 32, 41, 36, 43, 11, 20, 16, 9,},	//26
			new[]{ 33, 42, 37, 44, 12, 21, 17, 10,},	//27
			new[]{ 34, 43, 38, 45, 13, 22, 18, 11,},	//28
			new[]{ 35, 44, 39, 46, 14, 23, 19, 12,},	//29
			new[]{ 36, 45, 47, 15, 20, 13,},	//30
			new[]{ 37, 46, 21, 14,},	//31
			new[]{ 42, 49, 17, 26,},	//32
			new[]{ 48, 43, 50, 18, 27, 16,},	//33
			new[]{ 40, 49, 44, 51, 19, 28, 24, 17,},	//34
			new[]{ 41, 50, 45, 52, 20, 29, 25, 18,},	//35
			new[]{ 42, 51, 46, 53, 21, 30, 26, 19,},	//36
			new[]{ 43, 52, 47, 54, 22, 31, 27, 20,},	//37
			new[]{ 44, 53, 55, 23, 28, 21,},	//38
			new[]{ 45, 54, 29, 22,},	//39
			new[]{ 50, 57, 25, 34,},	//40
			new[]{ 56, 51, 58, 26, 35, 24,},	//41
			new[]{ 48, 57, 52, 59, 27, 36, 32, 25,},	//42
			new[]{ 49, 58, 53, 60, 28, 37, 33, 26,},	//43
			new[]{ 50, 59, 54, 61, 29, 38, 34, 27,},	//44
			new[]{ 51, 60, 55, 62, 30, 39, 35, 28,},	//45
			new[]{ 52, 61, 63, 31, 36, 29,},	//46
			new[]{ 53, 62, 37, 30,},	//47
			new[]{ 58, 33, 42,},	//48
			new[]{ 59, 34, 43, 32,},	//49
			new[]{ 56, 60, 35, 44, 40, 33,},	//50
			new[]{ 57, 61, 36, 45, 41, 34,},	//51
			new[]{ 58, 62, 37, 46, 42, 35,},	//52
			new[]{ 59, 63, 38, 47, 43, 36,},	//53
			new[]{ 60, 39, 44, 37,},	//54
			new[]{ 61, 45, 38,},	//55
			new[]{ 41, 50,},	//56
			new[]{ 42, 51, 40,},	//57
			new[]{ 43, 52, 48, 41,},	//58
			new[]{ 44, 53, 49, 42,},	//59
			new[]{ 45, 54, 50, 43,},	//60
			new[]{ 46, 55, 51, 44,},	//61
			new[]{ 47, 52, 45,},	//62
			new[]{ 53, 46,},	//63
    }
      
		public static int[][] KingMoves = new[]
		{
			new[]{ 8, 1, 9,},	//0
			new[]{ 9, 2, 0, 8, 10,},	//1
			new[]{ 10, 3, 1, 9, 11,},	//2
			new[]{ 11, 4, 2, 10, 12,},	//3
			new[]{ 12, 5, 3, 11, 13,},	//4
			new[]{ 13, 6, 4, 12, 14,},	//5
			new[]{ 14, 7, 5, 13, 15,},	//6
			new[]{ 15, 6, 14,},	//7
			new[]{ 16, 0, 9, 17, 1,},	//8
			new[]{ 17, 1, 10, 8, 16, 18, 2, 0,},	//9
			new[]{ 18, 2, 11, 9, 17, 19, 3, 1,},	//10
			new[]{ 19, 3, 12, 10, 18, 20, 4, 2,},	//11
			new[]{ 20, 4, 13, 11, 19, 21, 5, 3,},	//12
			new[]{ 21, 5, 14, 12, 20, 22, 6, 4,},	//13
			new[]{ 22, 6, 15, 13, 21, 23, 7, 5,},	//14
			new[]{ 23, 7, 14, 22, 6,},	//15
			new[]{ 24, 8, 17, 25, 9,},	//16
			new[]{ 25, 9, 18, 16, 24, 26, 10, 8,},	//17
			new[]{ 26, 10, 19, 17, 25, 27, 11, 9,},	//18
			new[]{ 27, 11, 20, 18, 26, 28, 12, 10,},	//19
			new[]{ 28, 12, 21, 19, 27, 29, 13, 11,},	//20
			new[]{ 29, 13, 22, 20, 28, 30, 14, 12,},	//21
			new[]{ 30, 14, 23, 21, 29, 31, 15, 13,},	//22
			new[]{ 31, 15, 22, 30, 14,},	//23
			new[]{ 32, 16, 25, 33, 17,},	//24
			new[]{ 33, 17, 26, 24, 32, 34, 18, 16,},	//25
			new[]{ 34, 18, 27, 25, 33, 35, 19, 17,},	//26
			new[]{ 35, 19, 28, 26, 34, 36, 20, 18,},	//27
			new[]{ 36, 20, 29, 27, 35, 37, 21, 19,},	//28
			new[]{ 37, 21, 30, 28, 36, 38, 22, 20,},	//29
			new[]{ 38, 22, 31, 29, 37, 39, 23, 21,},	//30
			new[]{ 39, 23, 30, 38, 22,},	//31
			new[]{ 40, 24, 33, 41, 25,},	//32
			new[]{ 41, 25, 34, 32, 40, 42, 26, 24,},	//33
			new[]{ 42, 26, 35, 33, 41, 43, 27, 25,},	//34
			new[]{ 43, 27, 36, 34, 42, 44, 28, 26,},	//35
			new[]{ 44, 28, 37, 35, 43, 45, 29, 27,},	//36
			new[]{ 45, 29, 38, 36, 44, 46, 30, 28,},	//37
			new[]{ 46, 30, 39, 37, 45, 47, 31, 29,},	//38
			new[]{ 47, 31, 38, 46, 30,},	//39
			new[]{ 48, 32, 41, 49, 33,},	//40
			new[]{ 49, 33, 42, 40, 48, 50, 34, 32,},	//41
			new[]{ 50, 34, 43, 41, 49, 51, 35, 33,},	//42
			new[]{ 51, 35, 44, 42, 50, 52, 36, 34,},	//43
			new[]{ 52, 36, 45, 43, 51, 53, 37, 35,},	//44
			new[]{ 53, 37, 46, 44, 52, 54, 38, 36,},	//45
			new[]{ 54, 38, 47, 45, 53, 55, 39, 37,},	//46
			new[]{ 55, 39, 46, 54, 38,},	//47
			new[]{ 56, 40, 49, 57, 41,},	//48
			new[]{ 57, 41, 50, 48, 56, 58, 42, 40,},	//49
			new[]{ 58, 42, 51, 49, 57, 59, 43, 41,},	//50
			new[]{ 59, 43, 52, 50, 58, 60, 44, 42,},	//51
			new[]{ 60, 44, 53, 51, 59, 61, 45, 43,},	//52
			new[]{ 61, 45, 54, 52, 60, 62, 46, 44,},	//53
			new[]{ 62, 46, 55, 53, 61, 63, 47, 45,},	//54
			new[]{ 63, 47, 54, 62, 46,},	//55
			new[]{ 48, 57, 49,},	//56
			new[]{ 49, 58, 56, 50, 48,},	//57
			new[]{ 50, 59, 57, 51, 49,},	//58
			new[]{ 51, 60, 58, 52, 50,},	//59
			new[]{ 52, 61, 59, 53, 51,},	//60
			new[]{ 53, 62, 60, 54, 52,},	//61
			new[]{ 54, 63, 61, 55, 53,},	//62
			new[]{ 55, 62, 54,},	//63
		};

		public static int[][][] BishopMoves = new[]
		{
			new[]{new[]{9,18,27,36,45,54,63}, },	//0
			new[]{new[]{8}, new[]{10,19,28,37,46,55}, },	//1
			new[]{new[]{9,16}, new[]{11,20,29,38,47}, },	//2
			new[]{new[]{10,17,24}, new[]{12,21,30,39}, },	//3
			new[]{new[]{11,18,25,32}, new[]{13,22,31}, },	//4
			new[]{new[]{12,19,26,33,40}, new[]{14,23}, },	//5
			new[]{new[]{13,20,27,34,41,48}, new[]{15}, },	//6
			new[]{new[]{14,21,28,35,42,49,56}, },	//7
			new[]{new[]{17,26,35,44,53,62}, new[]{1}, },	//8
			new[]{new[]{16}, new[]{18,27,36,45,54,63}, new[]{2}, new[]{0} },	//9
			new[]{new[]{17,24}, new[]{19,28,37,46,55}, new[]{3}, new[]{1} },	//10
			new[]{new[]{18,25,32}, new[]{20,29,38,47}, new[]{4}, new[]{2} },	//11
			new[]{new[]{19,26,33,40}, new[]{21,30,39}, new[]{5}, new[]{3} },	//12
			new[]{new[]{20,27,34,41,48}, new[]{22,31}, new[]{6}, new[]{4} },	//13
			new[]{new[]{21,28,35,42,49,56}, new[]{23}, new[]{7}, new[]{5} },	//14
			new[]{new[]{22,29,36,43,50,57}, new[]{6} },	//15
			new[]{new[]{25,34,43,52,61}, new[]{9,2}, },	//16
			new[]{new[]{24}, new[]{26,35,44,53,62}, new[]{10,3}, new[]{8} },	//17
			new[]{new[]{25,32}, new[]{27,36,45,54,63}, new[]{11,4}, new[]{9,0} },	//18
			new[]{new[]{26,33,40}, new[]{28,37,46,55}, new[]{12,5}, new[]{10,1} },	//19
			new[]{new[]{27,34,41,48}, new[]{29,38,47}, new[]{13,6}, new[]{11,2} },	//20
			new[]{new[]{28,35,42,49,56}, new[]{30,39}, new[]{14,7}, new[]{12,3} },	//21
			new[]{new[]{29,36,43,50,57}, new[]{31}, new[]{15}, new[]{13,4} },	//22
			new[]{new[]{30,37,44,51,58}, new[]{14,5} },	//23
			new[]{new[]{33,42,51,60}, new[]{17,10,3}, },	//24
			new[]{new[]{32}, new[]{34,43,52,61}, new[]{18,11,4}, new[]{16} },	//25
			new[]{new[]{33,40}, new[]{35,44,53,62}, new[]{19,12,5}, new[]{17,8} },	//26
			new[]{new[]{34,41,48}, new[]{36,45,54,63}, new[]{20,13,6}, new[]{18,9,0} },	//27
			new[]{new[]{35,42,49,56}, new[]{37,46,55}, new[]{21,14,7}, new[]{19,10,1} },	//28
			new[]{new[]{36,43,50,57}, new[]{38,47}, new[]{22,15}, new[]{20,11,2} },	//29
			new[]{new[]{37,44,51,58}, new[]{39}, new[]{23}, new[]{21,12,3} },	//30
			new[]{new[]{38,45,52,59}, new[]{22,13,4} },	//31
			new[]{new[]{41,50,59}, new[]{25,18,11,4}, },	//32
			new[]{new[]{40}, new[]{42,51,60}, new[]{26,19,12,5}, new[]{24} },	//33
			new[]{new[]{41,48}, new[]{43,52,61}, new[]{27,20,13,6}, new[]{25,16} },	//34
			new[]{new[]{42,49,56}, new[]{44,53,62}, new[]{28,21,14,7}, new[]{26,17,8} },	//35
			new[]{new[]{43,50,57}, new[]{45,54,63}, new[]{29,22,15}, new[]{27,18,9,0} },	//36
			new[]{new[]{44,51,58}, new[]{46,55}, new[]{30,23}, new[]{28,19,10,1} },	//37
			new[]{new[]{45,52,59}, new[]{47}, new[]{31}, new[]{29,20,11,2} },	//38
			new[]{new[]{46,53,60}, new[]{30,21,12,3} },	//39
			new[]{new[]{49,58}, new[]{33,26,19,12,5}, },	//40
			new[]{new[]{48}, new[]{50,59}, new[]{34,27,20,13,6}, new[]{32} },	//41
			new[]{new[]{49,56}, new[]{51,60}, new[]{35,28,21,14,7}, new[]{33,24} },	//42
			new[]{new[]{50,57}, new[]{52,61}, new[]{36,29,22,15}, new[]{34,25,16} },	//43
			new[]{new[]{51,58}, new[]{53,62}, new[]{37,30,23}, new[]{35,26,17,8} },	//44
			new[]{new[]{52,59}, new[]{54,63}, new[]{38,31}, new[]{36,27,18,9,0} },	//45
			new[]{new[]{53,60}, new[]{55}, new[]{39}, new[]{37,28,19,10,1} },	//46
			new[]{new[]{54,61}, new[]{38,29,20,11,2} },	//47
			new[]{new[]{57}, new[]{41,34,27,20,13,6}, },	//48
			new[]{new[]{56}, new[]{58}, new[]{42,35,28,21,14,7}, new[]{40} },	//49
			new[]{new[]{57}, new[]{59}, new[]{43,36,29,22,15}, new[]{41,32} },	//50
			new[]{new[]{58}, new[]{60}, new[]{44,37,30,23}, new[]{42,33,24} },	//51
			new[]{new[]{59}, new[]{61}, new[]{45,38,31}, new[]{43,34,25,16} },	//52
			new[]{new[]{60}, new[]{62}, new[]{46,39}, new[]{44,35,26,17,8} },	//53
			new[]{new[]{61}, new[]{63}, new[]{47}, new[]{45,36,27,18,9,0} },	//54
			new[]{new[]{62}, new[]{46,37,28,19,10,1} },	//55
			new[]{new[]{49,42,35,28,21,14,7}, },	//56
			new[]{new[]{50,43,36,29,22,15}, new[]{48} },	//57
			new[]{new[]{51,44,37,30,23}, new[]{49,40} },	//58
			new[]{new[]{52,45,38,31}, new[]{50,41,32} },	//59
			new[]{new[]{53,46,39}, new[]{51,42,33,24} },	//60
			new[]{new[]{54,47}, new[]{52,43,34,25,16} },	//61
			new[]{new[]{55}, new[]{53,44,35,26,17,8} },	//62
			new[]{ new[] { 54, 45, 36, 27, 18, 9, 0} },	//63
		};


		public static int[][][] RookMoves = new[]
		{
			new[]{new[]{8,16,24,32,40,48,56}, new[]{1,2,3,4,5,6,7}, },	//0
			new[]{new[]{9,17,25,33,41,49,57}, new[]{2,3,4,5,6,7}, new[]{0}, },	//1
			new[]{new[]{10,18,26,34,42,50,58}, new[]{3,4,5,6,7}, new[]{1,0}, },	//2
			new[]{new[]{11,19,27,35,43,51,59}, new[]{4,5,6,7}, new[]{2,1,0}, },	//3
			new[]{new[]{12,20,28,36,44,52,60}, new[]{5,6,7}, new[]{3,2,1,0}, },	//4
			new[]{new[]{13,21,29,37,45,53,61}, new[]{6,7}, new[]{4,3,2,1,0}, },	//5
			new[]{new[]{14,22,30,38,46,54,62}, new[]{7}, new[]{5,4,3,2,1,0}, },	//6
			new[]{new[]{15,23,31,39,47,55,63}, new[]{6,5,4,3,2,1,0}, },	//7
			new[]{new[]{16,24,32,40,48,56}, new[]{0}, new[]{9,10,11,12,13,14,15}, },	//8
			new[]{new[]{17,25,33,41,49,57}, new[]{1}, new[]{10,11,12,13,14,15}, new[]{8}, },	//9
			new[]{new[]{18,26,34,42,50,58}, new[]{2}, new[]{11,12,13,14,15}, new[]{9,8}, },	//10
			new[]{new[]{19,27,35,43,51,59}, new[]{3}, new[]{12,13,14,15}, new[]{10,9,8}, },	//11
			new[]{new[]{20,28,36,44,52,60}, new[]{4}, new[]{13,14,15}, new[]{11,10,9,8}, },	//12
			new[]{new[]{21,29,37,45,53,61}, new[]{5}, new[]{14,15}, new[]{12,11,10,9,8}, },	//13
			new[]{new[]{22,30,38,46,54,62}, new[]{6}, new[]{15}, new[]{13,12,11,10,9,8}, },	//14
			new[]{new[]{23,31,39,47,55,63}, new[]{7}, new[]{14,13,12,11,10,9,8}, },	//15
			new[]{new[]{24,32,40,48,56}, new[]{8,0}, new[]{17,18,19,20,21,22,23}, },	//16
			new[]{new[]{25,33,41,49,57}, new[]{9,1}, new[]{18,19,20,21,22,23}, new[]{16}, },	//17
			new[]{new[]{26,34,42,50,58}, new[]{10,2}, new[]{19,20,21,22,23}, new[]{17,16}, },	//18
			new[]{new[]{27,35,43,51,59}, new[]{11,3}, new[]{20,21,22,23}, new[]{18,17,16}, },	//19
			new[]{new[]{28,36,44,52,60}, new[]{12,4}, new[]{21,22,23}, new[]{19,18,17,16}, },	//20
			new[]{new[]{29,37,45,53,61}, new[]{13,5}, new[]{22,23}, new[]{20,19,18,17,16}, },	//21
			new[]{new[]{30,38,46,54,62}, new[]{14,6}, new[]{23}, new[]{21,20,19,18,17,16}, },	//22
			new[]{new[]{31,39,47,55,63}, new[]{15,7}, new[]{22,21,20,19,18,17,16}, },	//23
			new[]{new[]{32,40,48,56}, new[]{16,8,0}, new[]{25,26,27,28,29,30,31}, },	//24
			new[]{new[]{33,41,49,57}, new[]{17,9,1}, new[]{26,27,28,29,30,31}, new[]{24}, },  //25
			new[]{new[]{34,42,50,58}, new[]{18,10,2}, new[]{27,28,29,30,31}, new[]{25,24}, },	//26
			new[]{new[]{35,43,51,59}, new[]{19,11,3}, new[]{28,29,30,31}, new[]{26,25,24}, },	//27
			new[]{new[]{36,44,52,60}, new[]{20,12,4}, new[]{29,30,31}, new[]{27,26,25,24}, },	//28
			new[]{new[]{37,45,53,61}, new[]{21,13,5}, new[]{30,31}, new[]{28,27,26,25,24}, },	//29
			new[]{new[]{38,46,54,62}, new[]{22,14,6}, new[]{31}, new[]{29,28,27,26,25,24}, },	//30
			new[]{new[]{39,47,55,63}, new[]{23,15,7}, new[]{30,29,28,27,26,25,24}, },	//31
			new[]{new[]{40,48,56}, new[]{24,16,8,0}, new[]{33,34,35,36,37,38,39}, },	//32
			new[]{new[]{41,49,57}, new[]{25,17,9,1}, new[]{34,35,36,37,38,39}, new[]{32}, },	//33
			new[]{new[]{42,50,58}, new[]{26,18,10,2}, new[]{35,36,37,38,39}, new[]{33,32}, },	//34
			new[]{new[]{43,51,59}, new[]{27,19,11,3}, new[]{36,37,38,39}, new[]{34,33,32}, },	//35
			new[]{new[]{44,52,60}, new[]{28,20,12,4}, new[]{37,38,39}, new[]{35,34,33,32}, },	//36
			new[]{new[]{45,53,61}, new[]{29,21,13,5}, new[]{38,39}, new[]{36,35,34,33,32}, },	//37
			new[]{new[]{46,54,62}, new[]{30,22,14,6}, new[]{39}, new[]{37,36,35,34,33,32}, },	//38
			new[]{new[]{47,55,63}, new[]{31,23,15,7}, new[]{38,37,36,35,34,33,32}, },	//39
			new[]{new[]{48,56}, new[]{32,24,16,8,0}, new[]{41,42,43,44,45,46,47}, },	//40
			new[]{new[]{49,57}, new[]{33,25,17,9,1}, new[]{42,43,44,45,46,47}, new[]{40}, },	//41
			new[]{new[]{50,58}, new[]{34,26,18,10,2}, new[]{43,44,45,46,47}, new[]{41,40}, },	//42
			new[]{new[]{51,59}, new[]{35,27,19,11,3}, new[]{44,45,46,47}, new[]{42,41,40}, },	//43
			new[]{new[]{52,60}, new[]{36,28,20,12,4}, new[]{45,46,47}, new[]{43,42,41,40}, },	//44
			new[]{new[]{53,61}, new[]{37,29,21,13,5}, new[]{46,47}, new[]{44,43,42,41,40}, },	//45
			new[]{new[]{54,62}, new[]{38,30,22,14,6}, new[]{47}, new[]{45,44,43,42,41,40}, },	//46
			new[]{new[]{55,63}, new[]{39,31,23,15,7}, new[]{46,45,44,43,42,41,40}, },	//47
			new[]{new[]{56}, new[]{40,32,24,16,8,0}, new[]{49,50,51,52,53,54,55}, },	//48
			new[]{new[]{57}, new[]{41,33,25,17,9,1}, new[]{50,51,52,53,54,55}, new[]{48}, },	//49
			new[]{new[]{58}, new[]{42,34,26,18,10,2}, new[]{51,52,53,54,55}, new[]{49,48}, },	//50
			new[]{new[]{59}, new[]{43,35,27,19,11,3}, new[]{52,53,54,55}, new[]{50,49,48}, },	//51
			new[]{new[]{60}, new[]{44,36,28,20,12,4}, new[]{53,54,55}, new[]{51,50,49,48}, },	//52
			new[]{new[]{61}, new[]{45,37,29,21,13,5}, new[]{54,55}, new[]{52,51,50,49,48}, },	//53
			new[]{new[]{62}, new[]{46,38,30,22,14,6}, new[]{55}, new[]{53,52,51,50,49,48}, },	//54
			new[]{new[]{63}, new[]{47,39,31,23,15,7}, new[]{54,53,52,51,50,49,48}, },	//55
			new[]{new[]{48,40,32,24,16,8,0}, new[]{57,58,59,60,61,62,63}, },	//56
			new[]{new[]{49,41,33,25,17,9,1}, new[]{58,59,60,61,62,63}, new[]{56}, },	//57
			new[]{new[]{50,42,34,26,18,10,2}, new[]{59,60,61,62,63}, new[]{57,56}, },	//58
			new[]{new[]{51,43,35,27,19,11,3}, new[]{60,61,62,63}, new[]{58,57,56}, },	//59
			new[]{new[]{52,44,36,28,20,12,4}, new[]{61,62,63}, new[]{59,58,57,56}, },	//60
			new[]{new[]{53,45,37,29,21,13,5}, new[]{62,63}, new[]{60,59,58,57,56}, },	//61
			new[]{new[]{54,46,38,30,22,14,6}, new[]{63}, new[]{61,60,59,58,57,56}, },	//62
			new[]{new[]{55,47,39,31,23,15,7}, new[]{62,61,60,59,58,57,56}, }	//63
        };
		

		public static int[][][][] PawnMoves = new[]{
			new[]
			{  // white
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//0
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//1
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//2
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//3
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//4
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//5
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//6
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//7
				new[]{ new[] { 16,24 }, new[] { 17 } },				//8
				new[]{ new[] { 17,25 }, new[] { 16,18 } },			//9
				new[]{ new[] { 18,26 }, new[] { 17,19 } },			//10
				new[]{ new[] { 19,27 }, new[] { 18,20 } },			//11
				new[]{ new[] { 20,28 }, new[] { 19,21 } },			//12
				new[]{ new[] { 21,29 }, new[] { 20,22 } },			//13
				new[]{ new[] { 22,30 }, new[] { 21,23 } },			//14
				new[]{ new[] { 23,31 }, new[] { 22 } },				//15
				new[]{ new[] { 24 }, new[] { 25 } },				//16
				new[]{ new[] { 25 }, new[] { 24,26 } },				//17
				new[]{ new[] { 26 }, new[] { 25,27 } },				//18
				new[]{ new[] { 27 }, new[] { 26,28 } },				//19
				new[]{ new[] { 28 }, new[] { 27,29 } },				//20
				new[]{ new[] { 29 }, new[] { 28,30 } },				//21
				new[]{ new[] { 30 }, new[] { 29,31 } },				//22
				new[]{ new[] { 31 }, new[] { 30 } },				//23
				new[]{ new[] { 32 }, new[] { 33 } },				//24
				new[]{ new[] { 33 }, new[] { 32,34 } },				//25
				new[]{ new[] { 34 }, new[] { 33,35 } },				//26
				new[]{ new[] { 35 }, new[] { 34,36 } },				//27
				new[]{ new[] { 36 }, new[] { 35,37 } },				//28
				new[]{ new[] { 37 }, new[] { 36,38 } },				//29
				new[]{ new[] { 38 }, new[] { 37,39 } },				//30
				new[]{ new[] { 39 }, new[] { 38 } },				//31
				new[]{ new[] { 40 }, new[] { 41 } },				//32
				new[]{ new[] { 41 }, new[] { 40,42 } },				//33
				new[]{ new[] { 42 }, new[] { 41,43 } },				//34
				new[]{ new[] { 43 }, new[] { 42,44 } },				//35
				new[]{ new[] { 44 }, new[] { 43,45 } },				//36
				new[]{ new[] { 45 }, new[] { 44,46 } },				//37
				new[]{ new[] { 46 }, new[] { 45,47 } },				//38
				new[]{ new[] { 47 }, new[] { 46 } },				//39
				new[]{ new[] { 48 }, new[] { 49 } },				//40
				new[]{ new[] { 49 }, new[] { 48,50 } },				//41
				new[]{ new[] { 50 }, new[] { 49,51 } },				//42
				new[]{ new[] { 51 }, new[] { 50,52 } },				//43
				new[]{ new[] { 52 }, new[] { 51,53 } },				//44
				new[]{ new[] { 53 }, new[] { 52,54 } },				//45
				new[]{ new[] { 54 }, new[] { 53,55 } },				//46
				new[]{ new[] { 55 }, new[] { 54 } },				//47
				new[]{ new[] { 56 }, new[] { 57 } },				//48
				new[]{ new[] { 57 }, new[] { 56,58 } },				//49
				new[]{ new[] { 58 }, new[] { 57,59 } },				//50
				new[]{ new[] { 59 }, new[] { 58,60 } },				//51
				new[]{ new[] { 60 }, new[] { 59,61 } },				//52
				new[]{ new[] { 61 }, new[] { 60,62 } },				//53
				new[]{ new[] { 62 }, new[] { 61,63 } },				//54
				new[]{ new[] { 63 }, new[] { 62 } },				//55
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//56
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//57
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//58
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//59
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//60
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//61
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//62
				new[]{ Array.Empty<int>(), Array.Empty<int>() }		//63
			},
			new[]
			{  // black
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//0
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//1
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//2
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//3
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//4
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//5
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//6
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//7
				new[]{ new[] { 0 }, new[] { 1 } },					//8
				new[]{ new[] { 1 }, new[] { 2,0 } },				//9
				new[]{ new[] { 2 }, new[] { 3,1 } },				//10
				new[]{ new[] { 3 }, new[] { 4,2 } },				//11
				new[]{ new[] { 4 }, new[] { 5,3 } },				//12
				new[]{ new[] { 5 }, new[] { 6,4 } },				//13
				new[]{ new[] { 6 }, new[] { 7,5 } },				//14
				new[]{ new[] { 7 }, new[] { 6 } },					//15
				new[]{ new[] { 8 }, new[] { 9 } },					//16
				new[]{ new[] { 9 }, new[] { 10,8 } },				//17
				new[]{ new[] { 10 }, new[] { 11,9 } },				//18
				new[]{ new[] { 11 }, new[] { 12,10 } },				//19
				new[]{ new[] { 12 }, new[] { 13,11 } },				//20
				new[]{ new[] { 13 }, new[] { 14,12 } },				//21
				new[]{ new[] { 14 }, new[] { 15,13 } },				//22
				new[]{ new[] { 15 }, new[] { 14 } },				//23
				new[]{ new[] { 16 }, new[] { 17 } },				//24
				new[]{ new[] { 17 }, new[] { 18,16 } },				//25
				new[]{ new[] { 18 }, new[] { 19,17 } },				//26
				new[]{ new[] { 19 }, new[] { 20,18 } },				//27
				new[]{ new[] { 20 }, new[] { 21,19 } },				//28
				new[]{ new[] { 21 }, new[] { 22,20 } },				//29
				new[]{ new[] { 22 }, new[] { 23,21 } },				//30
				new[]{ new[] { 23 }, new[] { 22 } },				//31
				new[]{ new[] { 24 }, new[] { 25 } },				//32
				new[]{ new[] { 25 }, new[] { 26,24 } },				//33
				new[]{ new[] { 26 }, new[] { 27,25 } },				//34
				new[]{ new[] { 27 }, new[] { 28,26 } },				//35
				new[]{ new[] { 28 }, new[] { 29,27 } },				//36
				new[]{ new[] { 29 }, new[] { 30,28 } },				//37
				new[]{ new[] { 30 }, new[] { 31,29 } },				//38
				new[]{ new[] { 31 }, new[] { 30 } },				//39
				new[]{ new[] { 32 }, new[] { 33 } },				//40
				new[]{ new[] { 33 }, new[] { 34,32 } },				//41
				new[]{ new[] { 34 }, new[] { 35,33 } },				//42
				new[]{ new[] { 35 }, new[] { 36,34 } },				//43
				new[]{ new[] { 36 }, new[] { 37,35 } },				//44
				new[]{ new[] { 37 }, new[] { 38,36 } },				//45
				new[]{ new[] { 38 }, new[] { 39,37 } },				//46
				new[]{ new[] { 39 }, new[] { 38 } },				//47
				new[]{ new[] { 40,32 }, new[] { 41 } },				//48
				new[]{ new[] { 41,33 }, new[] { 42,40 } },			//49
				new[]{ new[] { 42,34 }, new[] { 43,41 } },			//50
				new[]{ new[] { 43,35 }, new[] { 44,42 } },			//51
				new[]{ new[] { 44,36 }, new[] { 45,43 } },			//52
				new[]{ new[] { 45,37 }, new[] { 46,44 } },			//53
				new[]{ new[] { 46,38 }, new[] { 47,45 } },			//54
				new[]{ new[] { 47,39 }, new[] { 46 } },				//55
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//56
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//57
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//58
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//59
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//60
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//61
				new[]{ Array.Empty<int>(), Array.Empty<int>() },	//62
				new[]{ Array.Empty<int>(), Array.Empty<int>() }		//63
			}
		};

	}
}
