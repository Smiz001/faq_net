﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FAQ_Net
{
  class RtfTable
  {
    public static String InsertTableInRichTextBox(int countRows, int countColumns, int columnWidth)
    {
      // Пример создания таблицы 2x2
      // {\rtf1
      // \trowd\cellx200 \cellx400\intbl \row
      // \trowd\cellx200 \cellx400\intbl \row
      // \pard}

      StringBuilder sringTableRtf = new StringBuilder();
      StringBuilder tableRowRtf = new StringBuilder();
      
      sringTableRtf.Append(@"{\rtf1 ");

      for (int j = 0; j < countColumns; j++)
      {
        if (j == 0)
          tableRowRtf.Append(@"\trowd");
        if (j == countColumns - 1)
          tableRowRtf.Append(string.Format("\\cellx{0}\\intbl \\row", ((j + 1) * columnWidth).ToString()));
        else
          tableRowRtf.Append(string.Format("\\cellx{0} ", ((j + 1) * columnWidth).ToString()));
      }

      for (int i = 0; i < countRows; i++)
      {
        sringTableRtf.AppendLine(tableRowRtf.ToString());
      }

      sringTableRtf.Append(@"\pard");
      sringTableRtf.Append(@"}");

      return sringTableRtf.ToString();
    }
  }
}