// ErrorToTextDlg.h : header file
//

#pragma once
#include "afxwin.h"


// CErrorToTextDlg dialog
class CErrorToTextDlg : public CDialog
{
// Construction
public:
	CErrorToTextDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_ERRORTOTEXT_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
private:
	CEdit edErrorValue;
	CButton cbUseLocalFile;
	CListBox lbInfo;
public:
	afx_msg void OnBnClickedButtonGetErrorInfo();
};
