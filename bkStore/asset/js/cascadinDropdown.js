// cascading dropdown
  $(document).ready(function()
  {
    $('select.cascading').change(getList);
    getList();
    function getList()
    {
     var url, target;
      var id = $(this).attr('id');
      var selectedValue = $(this).val();
        console.log('id: '+id + ' selectedvalue: '+ selectedValue);
      switch (id)
      {
        case 'division':
          if(selectedValue == '')	return;
          url = 'dropdown.php?find=district&id='+ selectedValue;
          target = 'district';
        break;
        
        case 'district':
          if($(this).val() == '')	return;
          url = 'dropdown.php?find=upazila&id='+ selectedValue;
          target = 'upazila';
        break;
        
        /*case 'Upazila':
          if($(this).val() == '')	return;
          url = 'results.php?find=information&id='+ selectedValue;
          target = 'information';
        break;*/
        
        default:
          url = 'dropdown.php?find=division';
          target = 'division';
      }
      $.get(
        url,
        { },
        function(data)
        {
            console.log(data);
          $('#'+target).html(data);
        }
      )
    }
    
  });

