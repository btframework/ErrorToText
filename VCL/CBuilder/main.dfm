object fmMain: TfmMain
  Left = 712
  Top = 318
  BorderStyle = bsSingle
  Caption = 'Get WCL Error Infor'
  ClientHeight = 441
  ClientWidth = 400
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  PixelsPerInch = 96
  TextHeight = 13
  object laTitle: TLabel
    Left = 16
    Top = 16
    Width = 375
    Height = 13
    Caption = 
      'Enter error code in HEX or DEC in the Edit Box below. HEX should' +
      ' start with 0x.'
  end
  object laErrorValue: TLabel
    Left = 16
    Top = 48
    Width = 54
    Height = 13
    Caption = 'Error value:'
  end
  object edErrorValue: TEdit
    Left = 88
    Top = 40
    Width = 105
    Height = 21
    TabOrder = 0
    Text = '0x00000000'
  end
  object cbUseLocalFile: TCheckBox
    Left = 208
    Top = 40
    Width = 97
    Height = 17
    Caption = 'Use local file'
    TabOrder = 1
  end
  object btGetErrorInfo: TButton
    Left = 288
    Top = 64
    Width = 99
    Height = 25
    Caption = 'Get Error Info'
    TabOrder = 2
    OnClick = btGetErrorInfoClick
  end
  object lbInfo: TListBox
    Left = 16
    Top = 96
    Width = 369
    Height = 337
    ItemHeight = 13
    TabOrder = 3
  end
end
