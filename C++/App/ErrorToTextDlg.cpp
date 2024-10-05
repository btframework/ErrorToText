// ErrorToTextDlg.cpp : implementation file
//

#include "stdafx.h"
#include "ErrorToText.h"
#include "ErrorToTextDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CErrorToTextDlg dialog




CErrorToTextDlg::CErrorToTextDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CErrorToTextDlg::IDD, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CErrorToTextDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT_ERROR_VALUE, edErrorValue);
	DDX_Control(pDX, IDC_CHECK_USE_LOCAL_FILE, cbUseLocalFile);
	DDX_Control(pDX, IDC_LIST_INFO, lbInfo);
}

BEGIN_MESSAGE_MAP(CErrorToTextDlg, CDialog)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON_GET_ERROR_INFO, &CErrorToTextDlg::OnBnClickedButtonGetErrorInfo)
END_MESSAGE_MAP()


// CErrorToTextDlg message handlers

BOOL CErrorToTextDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	edErrorValue.SetWindowText(_T("0x00000000"));

	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CErrorToTextDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CErrorToTextDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CErrorToTextDlg::OnBnClickedButtonGetErrorInfo()
{
	int Err;

	lbInfo.ResetContent();

	CString ErrStr;
	edErrorValue.GetWindowText(ErrStr);
	if (ErrStr.Find(_T("0x")) == 0)
		Err = _tcstol(ErrStr.GetBuffer(), NULL, 16);
	else
		Err = _tcstol(ErrStr.GetBuffer(), NULL, 10);

	tstring Path;
	if (cbUseLocalFile.GetCheck())
		Path = _T("..\\..\\..\\errors.xml");
	else
		Path = _T("https://www.btframework.com/errors.xml");
	
	if (ErrorInfo.Open(Path))
	{
		wclErrorDetails Details;
		if (ErrorInfo.GetDetails(Err, Details))
		{
			CString s;
			s.Format(_T("%.8X"), Err);
			lbInfo.AddString(_T("Error code: 0x") + s);
			lbInfo.AddString(_T("  Framework: ") + CString(Details.Framework.c_str()));
			lbInfo.AddString(_T("  Category: ") + CString(Details.Category.c_str()));
			lbInfo.AddString(_T("  Constant: ") + CString(Details.Constant.c_str()));
			lbInfo.AddString(_T("  Description: ") + CString(Details.Description.c_str()));
		}
		else
			lbInfo.AddString(_T("Get error details failed"));
		ErrorInfo.Close();

	}
	else
		AfxMessageBox(_T("wclGetErrorInfo failed"));
}
