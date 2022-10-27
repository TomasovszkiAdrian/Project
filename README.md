#include <iostream>
#include <vector>
#include <opencv2/core.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgproc.hpp>

using namespace std;
using namespace cv;

void zoldKeres(const Mat img, Mat_<Vec3b>& dest) {
	dest = img.clone();
	for (auto& p : dest)
	{
		if ((p[0] < p[1] && p[1] > p[2])) {

			p[2] = 0;
		}
	}
}

int main() {
	Mat img = imread("gumicukor2.jpg", IMREAD_COLOR);
	assert(!img.empty());

	Mat_<Vec3b> dest;
	medianBlur(img, img, 5);
	imwrite("filtered_stud.png", img);

	zoldKeres(img, dest);
	imwrite("result_stud.png", dest);



	waitKey();
	return 0;
}
 
	
	
int main(){
	Mat img = imread(".jpg", IMREAD_GRAYSCALE);
	assert(!img.empty());
	
	Mat dest;
	threshold(img, dest, 30, 255, THRESH_BINARY);
	
	imwrite(,dest);
	return 0;
	}
