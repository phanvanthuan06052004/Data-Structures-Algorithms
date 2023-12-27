#include <Windows.h>
#include <conio.h>
#include <string>
 
using namespace std;
 
// Khai báo các hằng số
const int nScreenWidth = 39;
const int nScreenHeight = 21;
 
const int nBoardWidth = 22;
const int nBoardHeight = 21;
 
const wstring detail = L" █▓░╚╝║═";
 
void configure()
{
    // Set kích thước cửa sổ console
    system("MODE 39, 22");
    
    HANDLE hConsoleOutput = GetStdHandle(STD_OUTPUT_HANDLE);
 
    CONSOLE_SCREEN_BUFFER_INFOEX csbiex;
    csbiex.cbSize = sizeof(CONSOLE_SCREEN_BUFFER_INFOEX);
    
    GetConsoleScreenBufferInfoEx(hConsoleOutput, &csbiex);
    
    csbiex.ColorTable[0] = RGB(0, 188, 212);
    csbiex.ColorTable[1] = RGB(63, 81, 181);
    csbiex.ColorTable[2] = RGB(255, 87, 34);
    csbiex.ColorTable[3] = RGB(255, 235, 59);
    csbiex.ColorTable[4] = RGB(76, 175, 80);
    csbiex.ColorTable[5] = RGB(156, 39, 176);
    csbiex.ColorTable[6] = RGB(237, 28, 36);
    csbiex.ColorTable[7] = RGB(242, 242, 242);
    csbiex.ColorTable[8] = RGB(248, 248, 248);
    csbiex.ColorTable[9] = RGB(20, 20, 20);
 
    // Thay đổi bảng màu
    SetConsoleScreenBufferInfoEx(hConsoleOutput, &csbiex);
}
 
// Vẽ khung
void Frame(wchar_t*& wcBuffer, wstring wsCaption, int nWidth, int nHeight, int nPosX, int nPosY)
{
    for (int i = nPosX; i < nWidth + nPosX; i++)
    {
        for (int j = nPosY; j < nHeight + nPosY; j++)
        {
            if (i == nPosX)
            {
                if (j == nPosY)
                {
                    wcBuffer[j * nScreenWidth + i] = L'╔';
                }
                else if (j == nHeight + nPosY - 1)
                {
                    wcBuffer[j * nScreenWidth + i] = L'╚';
                }
                else
                {
                    wcBuffer[j * nScreenWidth + i] = L'║';
                }
            }
            else if (i == nWidth + nPosX - 1)
            {
                if (j == nPosY)
                {
                    wcBuffer[j * nScreenWidth + i] = L'╗';
                }
                else if (j == nHeight + nPosY - 1)
                {
                    wcBuffer[j * nScreenWidth + i] = L'╝';
                }
                else
                {
                    wcBuffer[j * nScreenWidth + i] = L'║';
                }
            }
            else
            {
                if (j == nPosY || j == nHeight + nPosY - 1)
                {
                    wcBuffer[j * nScreenWidth + i] = L'═';
                }
                else
                {
                    wcBuffer[j * nScreenWidth + i] = L' ';
                }
 
            }
        }
    }
 
    int CapIndex = nPosY * nScreenWidth + (nPosX + 1);
    for (int i = 0; i < wsCaption.length(); i++, CapIndex++)
    {
        wcBuffer[CapIndex] = wsCaption.at(i);
    }
}
 
int main()
{
    // Set kích thước cửa sổ console và thay đổi bảng màu
    configure();
 
    // Tạo Console Screen Buffer
    HANDLE hConsole = CreateConsoleScreenBuffer(GENERIC_READ | GENERIC_WRITE, 0, NULL, CONSOLE_TEXTMODE_BUFFER, NULL);
    SetConsoleActiveScreenBuffer(hConsole);
 
    // Tạo mảng lưu thuộc tính màu sắc và mảng lưu ký tự
    WORD* pColor = new WORD[nScreenWidth * nScreenHeight];
    wchar_t* pBuffer = new wchar_t[nScreenWidth * nScreenHeight];
    for (int i = 0; i < nScreenWidth; i++)
    {
        for (int j = 0; j < nScreenHeight; j++)
        {
            pBuffer[j * nScreenWidth + i] = L' ';
            if (i == 0 || i >= nBoardWidth - 1 || j == nBoardHeight - 1)
            {
                pColor[j * nScreenWidth + i] = 8 * 16 + 9;
            }
            else
            {
                if (j % 2 == 1)
                {
                    if (i % 4 == 1 || i % 4 == 2)
                    {
                        pColor[j * nScreenWidth + i] = 8 * 16 + 9;
                    }
                    else
                    {
                        pColor[j * nScreenWidth + i] = 7 * 16 + 9;
                    }
                }
                else
                {
                    if (i % 4 == 3 || i % 4 == 0)
                    {
                        pColor[j * nScreenWidth + i] = 8 * 16 + 9;
                    }
                    else
                    {
                        pColor[j * nScreenWidth + i] = 7 * 16 + 9;
                    }
                }
            }
        }
    }
 
    // Tạo mảng đánh dấu Game Board
    int* pMatrix = new int[nBoardWidth * nBoardHeight];
    for (int i = 0; i < nBoardWidth; i++)
    {
        for (int j = 0; j < nBoardHeight; j++)
        {
            if (j == nBoardHeight - 1)
            {
                if (i == 0)
                {
                    pMatrix[j * nBoardWidth + i] = 4;
                }
                else if (i == nBoardWidth - 1)
                {
                    pMatrix[j * nBoardWidth + i] = 5;
                }
                else
                {
                    pMatrix[j * nBoardWidth + i] = 7;
                }
            }
            else
            {
                if (i == 0 || i == nBoardWidth - 1)
                {
                    pMatrix[j * nBoardWidth + i] = 6;
                }
                else
                {
                    pMatrix[j * nBoardWidth + i] = 0;
                }
            }
        }
    }
 
    // Chuyển mảng đánh dấu Game Board lên mảng lưu ký tự để hiển thị
    for (int i = 0; i < nBoardWidth; i++)
    {
        for (int j = 0; j < nBoardHeight; j++)
        {
            pBuffer[j * nScreenWidth + i] = detail[pMatrix[j * nBoardWidth + i]];
        }
    }
 
    // Vẽ các ô Score, Line, Next
    Frame(pBuffer, L"[ SCORE ]", 17, 3, nBoardWidth, 1);
    Frame(pBuffer, L"[ LINE ]", 17, 3, nBoardWidth, 4);
    Frame(pBuffer, L"[ NEXT ]", 17, 6, nBoardWidth, 7);
 
    // Hiển thị
    DWORD dwBytesWritten = 0;
    for (int i = 0; i < nScreenWidth; i++)
    {
        for (int j = 0; j < nScreenHeight; j++)
        {
            COORD cPos;
            cPos.X = i;
            cPos.Y = j;
            WriteConsoleOutputAttribute(hConsole, &pColor[j * nScreenWidth + i], 1, cPos, &dwBytesWritten);
        }
    }
    WriteConsoleOutputCharacter(hConsole, pBuffer, nScreenWidth * nScreenHeight, { 0,0 }, &dwBytesWritten);
    
    _getch();
    
    return 0;
}