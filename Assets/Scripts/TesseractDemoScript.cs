using UnityEngine;
using UnityEngine.UI;

public class TesseractDemoScript : MonoBehaviour
{
    [SerializeField] private Texture2D imageToRecognize;
	[SerializeField] private Texture2D imageToReset;
    [SerializeField] private Text displayText;
    [SerializeField] private RawImage outputImage;
	
	public Image CaptureImage;
	public bool CaptureImageActive;
	
    private TesseractDriver _tesseractDriver;
    private string _text = "";
    private Texture2D _texture;

    private void Start()
    {
		CaptureImageActive = false;
    }
	
	public void SetCaptureImageOCR(Texture2D imageCaptured){
		/*
		Texture2D texture = new Texture2D(imageCaptured.width, imageCaptured.height, TextureFormat.ARGB32, false);
        texture.SetPixels32(imageCaptured.GetPixels32());
        texture.Apply();
		*/
		CaptureImageActive = true;
        _tesseractDriver = new TesseractDriver();
        Recoginze(imageCaptured);
	}
	
	public void CaptureImageToOCR()
	{
		Texture2D texture = new Texture2D(imageToRecognize.width, imageToRecognize.height, TextureFormat.ARGB32, false);
        texture.SetPixels32(imageToRecognize.GetPixels32());
        texture.Apply();

        _tesseractDriver = new TesseractDriver();
        Recoginze(texture);
	}
	
	public void ResetCapture()
	{
		ClearTextDisplay();
		//
		Texture2D texture = new Texture2D(imageToReset.width, imageToReset.height, TextureFormat.ARGB32, false);
        texture.SetPixels32(imageToReset.GetPixels32());
        texture.Apply();
	}

    private void Recoginze(Texture2D outputTexture)
    {
        _texture = outputTexture;
        ClearTextDisplay();
        AddToTextDisplay(_tesseractDriver.CheckTessVersion());
        _tesseractDriver.Setup(OnSetupCompleteRecognize);
    }

    private void OnSetupCompleteRecognize()
    {
        AddToTextDisplay(_tesseractDriver.Recognize(_texture));
        AddToTextDisplay(_tesseractDriver.GetErrorMessage(), true);
        //SetImageDisplay();
    }

    private void ClearTextDisplay()
    {
        _text = "";
    }

    private void AddToTextDisplay(string text, bool isError = false)
    {
        if (string.IsNullOrWhiteSpace(text)) return;

        _text += (string.IsNullOrWhiteSpace(displayText.text) ? "" : "\n") + text;

        if (isError)
            Debug.LogError(text);
        else
            Debug.Log(text);
    }

    private void LateUpdate()
    {
        if (CaptureImageActive){
			displayText.text = _text;	
		}
    }

    private void SetImageDisplay()
    {
        RectTransform rectTransform = outputImage.GetComponent<RectTransform>();
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,
            rectTransform.rect.width * _tesseractDriver.GetHighlightedTexture().height / _tesseractDriver.GetHighlightedTexture().width);
        outputImage.texture = _tesseractDriver.GetHighlightedTexture();
    }
}