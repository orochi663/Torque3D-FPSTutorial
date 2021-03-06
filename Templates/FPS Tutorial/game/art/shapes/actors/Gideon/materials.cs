//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

singleton Material( actor_gideon_head_material_dts )
{
	mapTo = "head_d";
	diffuseMap[0] = "head_d";
	normalMap[0] = "head_n";
	specularMap[0] = "head_s";
	pixelSpecular[0] = true;
	specular[0] = "0.99 0.91 0.81";
	specularPower[0] = 16.0;
};

singleton Material( actor_gideon_body_material_dts )
{
	mapTo = "body_d";
	diffuseMap[0] = "body_d";
	specularMap[0] = "body_s";
	normalMap[0] = "body_n";
	pixelSpecular[0] = true;
	specular[0] = "0.99 0.91 0.81";
	specularPower[0] = 16.0;
};
