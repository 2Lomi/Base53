#include <iostream>
#include <Windows.h>
using namespace std;

int nScreenWidth = 120;
int nScreenHeight = 40;
//typedef unsigned long DUDE;
//typedef DUDE *THATSANAME;

//playerPosition
float fPlayerXPosition = 0;
float fPlayerYPosition = 0;
float fPlayerAngle = 0;

int nMapHeight = 16;
int nMapWidth = 16;

float fFOV = 3.14159 / 4.0;
float fDepth = 16.0f;

//int derp1(THATSANAME) {
//	return 0;
//}

int main()
{
	
	wchar_t *screen = new wchar_t[nScreenWidth*nScreenHeight];

	
	HANDLE WINAPI CreateConsoleScreenBuffer(
	_In_             DWORD               dwDesiredAccess,
	_In_             DWORD               dwShareMode,
	_In_opt_   const SECURITY_ATTRIBUTES *lpSecurityAttributes,
	_In_             DWORD               dwFlags,
	_Reserved_       LPVOID              lpScreenBufferData
	);
	
	//DUDE k;
	HANDLE hConsole = CreateConsoleScreenBuffer(GENERIC_READ | GENERIC_WRITE, 0, NULL, CONSOLE_TEXTMODE_BUFFER, NULL);
	SetConsoleActiveScreenBuffer(hConsole);

	DWORD dwBytesWritten = 0;

	//DUDE k;

	wstring map;

	map += L"################";
	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";

	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";

	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";

	map += L"#..............#";
	map += L"#..............#";
	map += L"#..............#";
	map += L"################";


	//derp1(&k);
	while (1) {

		for (int x = 0; x < nScreenHeight; x++)
		{
			float fRayAngle = (fPlayerAngle - fFOV / 2.00f) + ((float)x / (float)nScreenWidth) * fFOV;

			float fDistanceToWall = 0;
			bool bhitWall = false;

			float fEyeX = sinf(fRayAngle);
			float fEyeY = cosf(fRayAngle);

			while (!bhitWall && fDistanceToWall < fDepth) {
				fDistanceToWall += 0.1f;

				int nTestX = (int)(fPlayerXPosition + fEyeX * fDistanceToWall);
				int nTestY = (int)(fPlayerYPosition + fEyeY * fDistanceToWall);

				//test is fray is out of bounds
				if (nTestX < 0 || nTestX >= nMapWidth || nTestY < 0 || nTestY >= nMapHeight) {
					bhitWall = true;
					fDistanceToWall = fDepth;
				}
				else
				{
					if (map[nTestY * nMapWidth + nTestX] == '#') {
						bhitWall = true;
					}

				}
			}
		}

		screen[nScreenWidth * nScreenHeight - 1] = '\0';

		WriteConsoleOutputCharacter(hConsole, screen, nScreenWidth * nScreenHeight, { 0,0 }, &dwBytesWritten);

		

	}

	return 0;
}
