using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class TextRainbow : MonoBehaviour
{
    // Inspector�ŕҏW����ϐ�
    public bool IsTokeiMawari = true;
    public int ChangeSpeed = 0;
    // �ϊ��Ǘ��ϐ�
    public static int _ChangeCnt = 0;
    public static int _NijiStartId = 0;
    // �ϊ��Ǘ��萔
    public const string Df_Tag_Hedder = "<color=#Value>";
    public const string Df_Tag_Footer = "</color>";
    // ���F�̒��g�@�� 2���Âŋ�؂���[00 00 00]��[ R, G, B ]�̒l�ɂȂ��Ă���
    // �@�@�@�@�@�@�� ���̔z��̗v�f��ǉ��E�ҏW������I���W�i���̓����F������
    public static string[] Df_ColorTag = new string[]
    {
        "ff0000",
        "ffff00",
        "00ff00",
        "00ffff",
        "0000ff",
        "ff00ff",
    };

    /// <summary>
    /// �����荞�݃C�x���g
    /// </summary>
    void Update()
    {
        // �ݒ肵���X�s�[�h�ɍ��킹�ĐF�ύX�������Ă�
        _ChangeCnt--;
        if (_ChangeCnt <= 0)
        {
            _ChangeCnt = ChangeSpeed;
            SetTextColorChange(IsTokeiMawari, this.GetComponent<Text>());
        }
    }

    /// <summary>
    /// �e�L�X�g�F��ς��鏈���i�����荞�݁j
    /// </summary>
    /// <param name="TxtSet">�ύX����e�L�X�g�I�u�W�F�N�g</param>
    public static void SetTextColorChange(bool IsVecLR, Text TxtSet)
    {
        // �e�L�X�g�̕������擾��Tag��������菜��
        string textNoTag = TxtSet.text;
        textNoTag = textNoTag.Replace(Df_Tag_Footer, "");
        for (int i_ColorId = 0; i_ColorId < Df_ColorTag.Length; i_ColorId++)
        {
            textNoTag = textNoTag.Replace(Df_Tag_Hedder.Replace("Value", Df_ColorTag[i_ColorId]), "");
        }
        // �ꕶ�����F��ݒ�
        int setColorId = _NijiStartId;
        StringBuilder textSet = new StringBuilder();
        for (int i_Word = 0; i_Word < textNoTag.Length; i_Word++)
        {
            textSet.Append(Df_Tag_Hedder.Replace("Value", Df_ColorTag[setColorId]));
            textSet.Append(textNoTag.Substring(i_Word, 1));
            textSet.Append(Df_Tag_Footer);
            if (IsVecLR)
            {
                setColorId--;
                if (setColorId < 0)
                {
                    setColorId = Df_ColorTag.Length - 1;
                }
            }
            else
            {
                setColorId++;
                if (setColorId >= Df_ColorTag.Length)
                {
                    setColorId = 0;
                }
            }
        }
        // ����̊J�n�F���X�V
        _NijiStartId++;
        if (_NijiStartId >= Df_ColorTag.Length)
        {
            _NijiStartId = 0;
        }
        // �e�L�X�g������ύX
        TxtSet.text = textSet.ToString();
    }
}