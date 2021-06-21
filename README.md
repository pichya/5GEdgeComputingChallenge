# 5GEdgeComputingChallenge
Developed for the 5G Edge Computing Challenge with AWS and Verizon to build low-latency application using AWS Wavelength on Verizon’s 5G Edge.

# Summary
This coming September marks the 20th Anniversary of the tragic events of 9/11 at the World Trade Center. At the memorial site of the former twin towers, the two largest man-made waterfalls denote the footprints of the lost buildings. Along the rectangular perimeters of each of the waterfalls are 76 panels that list victims' names. Recent advances in augmented reality tech, live OCR, lidar capture, digital twinning, and XR-cloud streaming capabilities present an opportunity to experience the memorial site.

## Features
The proposed WTC Memorial App will allow visitors to scan any of the memorial lists of names to determine the exact panel (listed N1-N76 for the North Tower and S1-S76 for the South Tower) using an OCR cloud service like AWS Rekognition. The app demo uses Tesseract to extract the text of the panel. After the panel number is determined then a Unity Asset bundle/AR image targets database for that specific panel can be loaded to create interactive AR hotspots for the panel. Touching each of the names will display individual photographs and possible bios. This information is currently available inside the official 911 WTC memorial website. Determining the exact panel number would also determine the positioning of the user relative to the actual site. The 152 panels would be potential AR location anchors to position and view AR replicas of the original twin towers to float over the waterfalls. Using XR streaming services like ISAR and 5G Edge computing will allow for high res digital twin versions of the towers to be rendered in the cloud and streamed through the mobile device.

