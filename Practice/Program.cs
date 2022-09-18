using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class LoadGallery : MonoBehaviour
{
    public GameObject previewImage;
    private void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/Image"))
        {
            File.ReadAllBytes(Application.persistentDataPath + "/Image");
        }
    }




    public void OnClickLoadImage()
    {
        NativeGallery.GetImageFromGallery((file) => {
            FileInfo selected = new FileInfo(file);

            //용량 제한
            if (selected.Length > 500000000000)
            {
                return;
            }

            if (!string.IsNullOrEmpty(file))
            {
                StartCoroutine(LoadImage(file));
            }
        });
    }

    IEnumerator LoadImage(string path)
    {
        yield return null;

        byte[] fileData = File.ReadAllBytes(path);
        string fileName = Path.GetFileName(path).Split('.')[0];
        string savePath = Application.persistentDataPath + "/Image";

        if (!Directory.Exists(savePath))
        {
            Directory.CreateDirectory(savePath);
        }

        File.WriteAllBytes(savePath + fileName + ".png", fileData);

        var temp = File.ReadAllBytes(savePath + fileName + ".png");

        Texture2D texture = new Texture2D(0, 0);
        var result = texture.LoadImage(temp);

        var logo = Resources.Load("SceneInfoCanvas") as GameObject;
        logo.GetComponentInChildren<Image>().sprite = Sprite.Create(text, new Rect(0f, 0f, text.width, text.height), new Vector2(0.5f, 0.5f));
        $"이미지 변경 성공".Log();

        previewImage.GetComponentInChildren<Image>().sprite = Sprite.Create(text, new Rect(0f, 0f, text.width, text.height), new Vector2(0.5f, 0.5f));
    }

    private void LoadingImage(Texture2D text)
    {

    }
}