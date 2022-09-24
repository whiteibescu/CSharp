// Store single color
Color color;
PlayerPrefs.SetString("ColorKey", ColorUtility.ToHtmlStringRGB(color)); // without alpha
PlayerPrefs.SetString("ColorKey", ColorUtility.ToHtmlStringRGBA(color)); // with alpha

// Load single color
Color color;
ColorUtility.TryParseHtmlString("#" + PlayerPrefs.GetString("ColorKey"), out color);

// store color array
Color[] colors;
//// fill array with your colors ////
int numberOfColors = colors.Length;
for (int i = 0; i < numberOfColors; i++)
{
    Color color = colors[i];
    PlayerPrefs.SetString("ColorKey" + i, ColorUtility.ToHtmlStringRGBA(color)); // with alpha
}

// load color array
Color[] colors = new Color[numberOfColors];
for (int i = 0; i < numberOfColors; i++)
{
    ColorUtility.TryParseHtmlString("#" + PlayerPrefs.GetString("ColorKey" + i), out colors[i]);
}