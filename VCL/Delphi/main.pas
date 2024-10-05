unit main;

interface

uses
  Forms, Controls, StdCtrls, Classes, wclErrors;

type
  TfmMain = class(TForm)
    laTitle: TLabel;
    laErrorValue: TLabel;
    edErrorValue: TEdit;
    cbUseLocalFile: TCheckBox;
    btGetErrorInfo: TButton;
    lbInfo: TListBox;
    procedure btGetErrorInfoClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure FormDestroy(Sender: TObject);

  private
    ErrorInfo: TwclErrorInformation;
  end;

var
  fmMain: TfmMain;

implementation

uses
  SysUtils, Dialogs;

{$R *.dfm}

procedure TfmMain.btGetErrorInfoClick(Sender: TObject);
var
  Err: Integer;
  Path: string;
  Details: TwclErrorDetails;
begin
  lbInfo.Items.Clear;

  Err := StrToInt(edErrorValue.Text);

  if cbUseLocalFile.Checked then
    Path := '..\..\..\errors.xml'
  else
    Path := 'https://www.btframework.com/errors.xml';

  if ErrorInfo.Open(Path) then begin
    if ErrorInfo.GetDetails(Err, Details) then begin
      lbInfo.Items.Add('Error code: 0x' + IntToHex(Err, 8));
      lbInfo.Items.Add('  Framework: ' + Details.Framework);
      lbInfo.Items.Add('  Category: ' + Details.Category);
      lbInfo.Items.Add('  Constant: ' + Details.Constant);
      lbInfo.Items.Add('  Description: ' + Details.Description);
    end else
      lbInfo.Items.Add('Get error details failed');
    ErrorInfo.Close;
  end else
    ShowMessage('wclGetErrorInfo failed');
end;

procedure TfmMain.FormCreate(Sender: TObject);
begin
  ErrorInfo := TwclErrorInformation.Create;
end;

procedure TfmMain.FormDestroy(Sender: TObject);
begin
  ErrorInfo.Free;
end;

end.
