/// CarWaypoints v1.0 (����·�����) <summary>
/// ���ߣ��������
/// ���ͣ�http://www.cnblogs.com/shenggege
/// ��ϵ��ʽ��6087537@qq.com
/// ����޸ģ�2015/2/15 1:00
/// </summary>

using UnityEngine;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System;

/// ·���ר��XML���� <summary>
/// ·���ר��XML����
/// </summary>
public class WaypointsXML
{
    /// ���XML���� <summary>
    /// ���XML����
    /// </summary>
    /// <param name="_path">�����·���ʵ��</param>
    /// <param name="wm">xml�ļ�·��</param>
    public void AddXmlData(WaypointsModel wm, string xmlPath)
    {
        CheckXmlFile(xmlPath);//���XML�ļ�

        if (File.Exists(xmlPath))
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(xmlPath);

            XmlNode root = xmlDoc.SelectSingleNode("waypoints");
            XmlElement elmNew = xmlDoc.CreateElement("waypoint");
            elmNew.SetAttribute("index", wm.Index.ToString());

            XmlElement position = xmlDoc.CreateElement("position");
            position.InnerText = wm.Position.ToString();

            XmlElement rotation = xmlDoc.CreateElement("rotation");
            rotation.InnerText = wm.Rotation.ToString();
            XmlElement scale = xmlDoc.CreateElement("scale");
            scale.InnerText = wm.Scale.ToString();

            elmNew.AppendChild(position);
            elmNew.AppendChild(rotation);
            elmNew.AppendChild(scale);
            root.AppendChild(elmNew);
            xmlDoc.AppendChild(root);
            xmlDoc.Save(xmlPath);
        }
    }

    /// ��ȡXML���� <summary>
    /// ��ȡXML����
    /// </summary>
    /// <param name="_Waypoints">����·��㼯��</param>
    /// <param name="xmlPath">xml�ļ�·��</param>
    /// <param name="xmlString">xml�ı�����</param>
    public void GetXmlData(List<WaypointsModel> _Waypoints, string xmlPath = null, string xmlString = null)
    {
        if (File.Exists(xmlPath) || xmlPath == null)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (xmlPath == null)
            {
                xmlDoc.LoadXml(xmlString);
            }
            else
            {
                xmlDoc.Load(xmlPath);
            }

            XmlNodeList nodeList = xmlDoc.SelectSingleNode("waypoints").ChildNodes;

            foreach (XmlElement xml1 in nodeList)
            {
                WaypointsModel temWaypoint = new WaypointsModel();
                temWaypoint.Index = Convert.ToInt32(xml1.GetAttribute("index"));

                foreach (XmlElement xml2 in xml1.ChildNodes)
                {
                    switch (xml2.Name)
                    {
                        case "position":
                            temWaypoint.Position = StringToVector3(xml2.InnerText);
                            break;

                        case "rotation":
                            temWaypoint.Rotation = StringToQuaternion(xml2.InnerText);
                            break;

                        case "scale":
                            temWaypoint.Scale = StringToVector3(xml2.InnerText);
                            break;
                    }
                }

                //��ӽ�·��㼯��
                _Waypoints.Add(temWaypoint);
            }
        }
    }

    /// ���XML�ļ��Ƿ���ڣ��������򴴽� <summary>
    /// ���XML�ļ��Ƿ���ڣ��������򴴽�
    /// </summary>
    /// <param name="_path">xml�ļ�·��</param>
    private void CheckXmlFile(string _path)
    {
        //xml�Ƿ���ڣ��������򴴽�
        if (!File.Exists(_path))
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("waypoints");

            xmlDoc.AppendChild(root);
            xmlDoc.Save(_path);
        }
    }

    /// stringתVector3 <summary>
    /// stringתVector3
    /// </summary>
    /// <param name="st">�ַ���</param>
    /// <returns>����ת�����Vector3</returns>
    private Vector3 StringToVector3(string st)
    {
        string[] splitString = st.Replace("(", "").Replace(")", "").Split(new char[] { ',' });

        //��ֹ���̴��
        if (splitString.Length != 3)
            return new Vector3(0f, 0f, 0f);

        return new Vector3(
            float.Parse(splitString[0]),
            float.Parse(splitString[1]),
            float.Parse(splitString[2]));
    }

    /// stringתQuaternion <summary>
    /// stringתQuaternion
    /// </summary>
    /// <param name="st">�ַ���</param>
    /// <returns>����ת�����Vector4</returns>
    private Quaternion StringToQuaternion(string st)
    {
        string[] splitString = st.Replace("(", "").Replace(")", "").Split(new char[] { ',' });

        //��ֹ���̴��
        if (splitString.Length != 4)
            return new Quaternion(0f, 0f, 0f, 0f);

        return new Quaternion(
            float.Parse(splitString[0]),
            float.Parse(splitString[1]),
            float.Parse(splitString[2]),
            float.Parse(splitString[3]));
    }
}
