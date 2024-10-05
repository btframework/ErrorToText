//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "main.h"

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

  int Err = StrToInt(edErrorValue->Text);

  String Path;
  if (cbUseLocalFile->Checked)
	Path = "..\\..\\..\\errors.xml";
  else
	Path = "https://www.btframework.com/errors.xml";

  if (ErrorInfo->Open(Path))
  {
	TwclErrorDetails Details;
	if (ErrorInfo->GetDetails(Err, Details))
	{
	  lbInfo->Items->Add("Error code: 0x" + IntToHex(Err, 8));
	  lbInfo->Items->Add("  Framework: " + Details.Framework);
	  lbInfo->Items->Add("  Category: " + Details.Category);
	  lbInfo->Items->Add("  Constant: " + Details.Constant);
	  lbInfo->Items->Add("  Description: " + Details.Description);
	}
	else
	  lbInfo->Items->Add("Get error details failed");
	ErrorInfo->Close();
  }
  else
    ShowMessage("wclGetErrorInfo failed");
}
//---------------------------------------------------------------------------
void __fastcall TfmMain::FormCreate(TObject *Sender)
{
	ErrorInfo = new TwclErrorInformation();
}
//---------------------------------------------------------------------------

void __fastcall TfmMain::FormDestroy(TObject *Sender)
{
	ErrorInfo->Free();
}
//---------------------------------------------------------------------------

