using UnityEngine;         //�ޥ� Unity �R�W�Ŷ� (API)

// �R�W�Ŷ� �Ŷ��W��
// �h�H�}�o�i�H�ϥΩR�W�Ŷ��Ϲj�t���קK�Ĭ�
namespace lepo
{
    // ���} ���O �}���W�� (�P���W���j�צW�٬ۦP �j�p�g�@�� ����ϥΪŮ�P�S��r��
    public class topdown : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn���򥻸�� �Ҧp:���ʳt�� �ʵe�ѼƦW�ٻP���󵥵�
        // ��� field �y�k:�׹��� ��ƦW��(���w ��l��);
        private float speed = 10.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{���J�f(unity) ���Ѷ}�o���X�ʨt�Ϊ����f
        // ����ƥ�:����C�������@�� �B�z��l�� ���o��� ��ƪ�l��
        private void Awake()
        {
            //��X(�T��)�N�T����X��unity console(����O)ctrl + shift + c
            print("�ڬO����ƥ�~");

            //��� ���w�� ���o����<����W��>()
            // <�x��> �x��:������Φ�
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //��s�ƥ�:����C����H�C���60������ 60FPS(frame per second)
        //�B�z:����ʦ欰 ���� ���� �Y�� ���a��J �ƹ� ��L Ĳ�� �n��
        private void Update()
        {
            print("�ڦb Update �ƥ�");
        }
        #endregion

        #region ��k:���������\��(���z�� �t��k�ε{���϶�)
        #endregion
    }
}
