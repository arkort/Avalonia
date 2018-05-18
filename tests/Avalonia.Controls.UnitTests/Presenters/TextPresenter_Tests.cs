﻿using Avalonia.Controls.Presenters;
using Xunit;

namespace Avalonia.Controls.UnitTests.Presenters
{
    public class TextPresenter_Tests
    {
        [Fact]
        public void TextPresenter_can_contain_null_with_password_char_set()
        {
            var target = new TextPresenter
            {
                PasswordChar = '*'
            };

            Assert.NotNull(target.FormattedText);
        }

        [Fact]
        public void TextPresenter_can_contain_null_without_password_char_set()
        {
            var target = new TextPresenter();

            Assert.NotNull(target.FormattedText);
        }

        [Fact]
        public void Text_presenter_replaces_formatted_text_with_password_char()
        {
            var target = new TextPresenter
            {
                PasswordChar = '*',
                Text = "Test"
            };

            Assert.NotNull(target.FormattedText);
            Assert.Equal("****", target.FormattedText.Text);
        }
    }
}
