unit main;

interface

uses
  Forms, Controls, StdCtrls, Classes;

type
  TfmMain = class(TForm)
    laTitle: TLabel;
    laErrorValue: TLabel;
    edErrorValue: TEdit;
    cbUseLocalFile: TCheckBox;
    btGetErrorInfo: TButton;
    lbInfo: TListBox;
    procedure btGetErrorInfoClick(Sender: TObject);
  end;

var
  fmMain: TfmMain;

implementation

uses
  SysUtils, Dialogs, wclHelpers;

{$R *.dfm}

procedure TfmMain.btGetErrorInfoClick(Sender: TObject);
var
  Err: Integer;
  Res: Boolean;
  Framework: string;
  Category: string;
  Constant: string;
  Description: string;
begin
  lbInfo.Items.Clear;

  Err := StrToInt(edErrorValue.Text);
  if cbUseLocalFile.Checked then begin
    Res := wclGetErrorInfo('..\..\..\errors.xml', Err, Framework, Category,
      Constant, Description);
  end else
    Res := wclGetErrorInfo(Err, Framework, Category, Constant, Description);
    
  if Res then begin
    lbInfo.Items.Add('Error code: 0x' + IntToHex(Err, 8));
    lbInfo.Items.Add('  Framework: ' + Framework);
    lbInfo.Items.Add('  Category: ' + Category);
    lbInfo.Items.Add('  Constant: ' + Constant);
    lbInfo.Items.Add('  Description: ' + Description);
  end else
    ShowMessage('wclGetErrorInfo failed');
end;

end.
