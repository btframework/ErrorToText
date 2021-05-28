//---------------------------------------------------------------------------

#ifndef mainH
#define mainH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
//---------------------------------------------------------------------------
class TfmMain : public TForm
{
__published:	// IDE-managed Components
        TLabel *laTitle;
        TLabel *laErrorValue;
        TEdit *edErrorValue;
        TCheckBox *cbUseLocalFile;
        TButton *btGetErrorInfo;
        TListBox *lbInfo;
        void __fastcall btGetErrorInfoClick(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TfmMain(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TfmMain *fmMain;
//---------------------------------------------------------------------------
#endif
