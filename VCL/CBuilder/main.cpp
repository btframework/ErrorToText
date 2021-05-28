//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"
#include "wclHelpers.hpp"

#pragma comment(lib, "..\\..\\..\\..\\..\\WCL7\\VCL\\Lib\\Common\\C6\\wclCommon.lib")

//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TfmMain *fmMain;
//---------------------------------------------------------------------------
__fastcall TfmMain::TfmMain(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TfmMain::btGetErrorInfoClick(TObject *Sender)
{
  lbInfo->Items->Clear();

  bool Res;
  String Framework;
  String Category;
  String Constant;
  String Description;

  int Err = StrToInt(edErrorValue->Text);
  if (cbUseLocalFile->Checked)
  {
    Res = wclGetErrorInfo("..\\..\\..\\errors.xml", Err, Framework, Category,
      Constant, Description);
  }
  else
    Res = wclGetErrorInfo(Err, Framework, Category, Constant, Description);

  if (Res)
  {
    lbInfo->Items->Add("Error code: 0x" + IntToHex(Err, 8));
    lbInfo->Items->Add("  Framework: " + Framework);
    lbInfo->Items->Add("  Category: " + Category);
    lbInfo->Items->Add("  Constant: " + Constant);
    lbInfo->Items->Add("  Description: " + Description);
  }
  else
    ShowMessage("wclGetErrorInfo failed");
}
//---------------------------------------------------------------------------
